using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckDieLinkedin.View;
using Leaf.xNet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestWithSelenium.Helpers;
using TestWithSelenium.Models;
using TestWithSelenium.Service;

using Cookie = OpenQA.Selenium.Cookie;

namespace TestWithSelenium
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource = null;

        private ProxyType _ProxyType;

        private List<string> ProxyPool = new List<string>();

        private ConcurrentQueue<Person> Dataqueue = new ConcurrentQueue<Person>();
        private ConcurrentQueue<string> ProxyQueue = new ConcurrentQueue<string>();
        private List<ChromeService> _chromeServicePool = new List<ChromeService>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //_ViewGridDataService = new ViewGridDataService(dataGridView);
            LoadSetting();
        }
        private void LoadSetting()
        {
            numDrivers.Value = UIConfig.Drivers;
            boolProxy.Checked = UIConfig.UseProxy;
            listProxyType.SelectedIndex = UIConfig.ProxyType;

        }
        private void importData_BtnClick(Object sender, EventArgs e)
        {
            ImportDataForm import = new ImportDataForm($"Data");
            import.ShowDialog(this);
            if (import.ImportResult == DialogResult.OK && import.ImportedData.Count != 0)
            {
                Dataqueue = new ConcurrentQueue<Person>(import.ImportedData);
                lData.Text = $"{import.ImportedData.Count}";
            }
        }
        private void importProxy_BtnClick(Object sender, EventArgs e)
        {
            ImportProxyForm import = new ImportProxyForm($"Proxies");
            import.ShowDialog(this);
            if (import.ImportResult == DialogResult.OK && !import.ImportedData.Any())
            {
                ProxyPool = new List<string>(import.ImportedData);
                lProxy.Text = $"{import.ImportedData.Count}";
            }
        }
        private void start_BtnClick(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            dataGridView.Rows.Clear();
            IsRuning(true);
            int Maxthreads = (int)numDrivers.Value;
            new Thread(() =>
            {
                ThreadPool.SetMinThreads(Maxthreads, Maxthreads);
                Thread[] array = new Thread[Maxthreads];
                for(int i = 0; i < Maxthreads; i++)
                {
                    if (cancellationTokenSource.IsCancellationRequested)
                    {
                        break;
                    }
                    array[i] = new Thread((ThreadStart)delegate
                    {
                        while (!cancellationTokenSource.IsCancellationRequested)
                        {
                            //Start();
                            OpenChromeInstance(i);
                        }

                    });
                    array[i].Start();
                }
                for (int j = 0; j < Maxthreads; j++)
                {
                    if (array[j] != null)
                    {
                        array[j].Join();
                    }
                }
                Task.Delay(TimeSpan.FromSeconds(3)).Wait();
                IsRuning(false);
                cancellationTokenSource.Cancel();
                GC.SuppressFinalize(this);
                GC.WaitForFullGCApproach();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }).Start();
        }

        private void stop_BtnClick(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }
        private void proxyChecked_ValueChanged(object sender, EventArgs e)
        {
            UIConfig.UseProxy = boolProxy.Checked;
        }
        private void numDrivers_ValueChanged(object sender, EventArgs e)
        {
            UIConfig.Drivers = (int)numDrivers.Value;
        }
        private void proxyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIConfig.ProxyType = listProxyType.SelectedIndex;
            _ProxyType = listProxyType.SelectedIndex == 0 ? ProxyType.HTTP
                : listProxyType.SelectedIndex == 1 ? ProxyType.Socks4
                : ProxyType.Socks5;
        }
        private void IsRuning(bool status)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                btnStart.Enabled = !status;
                btnStop.Enabled = status;
            });
        }
        private void OpenChromeInstance(int instanceNumber)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                //string userProfilePath = @"C:\Users\roftp\AppData\Local\Google\Chrome\User Data\Profile 1";
                //options.AddArgument($"--user-data-dir=C:\\Users\\roftp\\AppData\\Local\\Google\\Chrome\\User Data");
                //options.AddArgument($"--profile-directory=Profile 1");
                using (IWebDriver driver = new ChromeDriver(options))
                {

                    ChromeService chromeService = new ChromeService(driver);
                    _chromeServicePool.Add(chromeService);
                    string url = "https://www.google.com/";
                    driver.Manage().Window.Minimize();

                    chromeService.GoToURLFullyLoaded(url);
                    if (Dataqueue.TryDequeue(out Person result))
                    {
                        IWebElement acceptTerm = driver.FindElement(By.XPath("//*[@id=\"L2AGLb\"]/div"));
                        acceptTerm.Click();

                        IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"gb\"]/div/div[2]/a"));
                        signInButton.Click();

                        IWebElement createNewAccount = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz/div/div[3]/div/div[2]/div/div/div[1]/div/button"));
                        createNewAccount.Click();

                        IWebElement clickPersonalUser = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz/div/div[3]/div/div[2]/div/div/div[2]/div/ul/li[1]"));
                        clickPersonalUser.Click();

                        IWebElement setFirstName = driver.FindElement(By.XPath("//*[@id=\"firstName\"]"));
                        setFirstName.SendKeys(result.FirstName.ToString());

                        IWebElement setLastName = driver.FindElement(By.XPath("//*[@id=\"lastName\"]"));
                        setLastName.SendKeys(result.LastName.ToString());

                        IWebElement clickNext = driver.FindElement(By.XPath("//*[@id=\"collectNameNext\"]/div/button/span"));
                        clickNext.Click();

                        chromeService.WaitToFullyLoadedURL();
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Set a 10 seconds timeout

                        // Wait until a specific element is visible after clicking "Next"
                        //IWebElement setMonth = driver.FindElement(By.XPath("//*[@id=\"month\"]"));
                        //SelectElement select = new SelectElement(setMonth);
                        //select.SelectByIndex(1);

                        IWebElement setDay = driver.FindElement(By.XPath("//*[@id=\"day\"]"));
                        setDay.SendKeys(result.DayOfBirth.Month.ToString());

                        //IWebElement setYear = driver.FindElement(By.XPath("//*[@id=\"year\"]"));
                        //setYear.SendKeys(result.DayOfBirth.Year.ToString());

                    }

                    //Data 

                    else
                    {
                        // Queue is empty
                        throw new Exception("data is enqueued");
                    }



                    Thread.Sleep(200000);// Adjust the sleep time as needed
                    _chromeServicePool.Remove(chromeService);
                    driver.Quit();
                    driver.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in instance {instanceNumber}: {ex.Message}");
            }
        }
        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are your want to exit ?", "exit confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                cancellationTokenSource.Cancel();
                CloseAllChrome();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void CloseAllChrome()
        {
            if (_chromeServicePool.Count > 0)
            {
                foreach (var driver in _chromeServicePool)
                {
                    try
                    {
                       driver.ShutDownDriver();
                    }
                    catch { }
                }
            }
            _chromeServicePool.Clear();
        }
        //private void InitRangeWindow(int threadsCount)
        //{
        //    ChromeUtils.getWidthChrome = (2 * ChromeUtils.getWidthScreen) / 8;
        //    ChromeUtils.getHeightChrome = ChromeUtils.getHeightScreen / 2;
        //    int maxThread = Convert.ToInt32(threadsCount);
        //    for (int i = 0; i < (int)maxThread; i++)
        //    {
        //        ChromeUtils.listPossitionApp.Add(0);
        //    }
        //}
    }
}
