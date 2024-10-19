using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWithSelenium.Models;

namespace TestWithSelenium
{
    public partial class ImportDataForm : Form
    {
        public List<Person> ImportedData
        {
            get
            {
                return _importdata;
            }
            set
            {
                _importdata = value;
                lbimported.Text = value.Count.ToString();
            }
        }
        private List<Person> _importdata;
        private string Title { get; set; }
        public string FileName { get; set; }
        public DialogResult ImportResult { get; set; }
        private bool Isloading
        {
            get
            {
                return _loading;
            }
            set
            {
                _loading = value;
                progressBar1.Visible = value;
                btnclipboard.Enabled = !value;
                btnok.Enabled = !value;
                btncacel.Enabled = !value;
                btnfile.Enabled = !value;
            }
        }
        bool _loading;
        public ImportDataForm(string title)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Title = title;
        }
        private string GetClipboardDataThread()
        {
            try
            {
                string clipboardData = null;
                Exception threadEx = null;
                Thread staThread = new Thread(
                    delegate ()
                    {
                        try
                        {
                            clipboardData = Clipboard.GetText(TextDataFormat.Text);
                        }

                        catch (Exception ex)
                        {
                            threadEx = ex;
                        }
                    });
                staThread.SetApartmentState(ApartmentState.STA);
                staThread.Start();
                staThread.Join();
                return clipboardData;
            }
            catch (Exception exception)
            {
                return string.Empty;
            }
        }

        private void btnclipboard_Click(object sender, EventArgs e)
        {
            Isloading = true;
            //ImportedData = new List<string>(GetClipboardDataThread().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)).Distinct().ToList();
            Isloading = false;
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Select CSV File", // Replace 'Title' with a hardcoded string or variable
                Filter = "CSV file |*.csv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Isloading = true;

                // Start a new thread to read the file
                new Thread(() =>
                {
                    try
                    {
                        var lines = File.ReadAllLines(openFileDialog.FileName).Distinct().ToList();


                        for (int i = 1; i < lines.Count; i++) 
                        {
                            var fields = lines[i].Split(',');

                            if (fields.Length == 4)
                            {
                                var person = new Person
                                {
                                    FirstName = fields[0],
                                    LastName = fields[1],
                                    Gender = fields[2],
                                    DayOfBirth = DateTime.ParseExact(fields[3], "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                                };
                                ImportedData.Add(person);
                            }
                        }

                        this.BeginInvoke((Action)(() =>
                        {

                            FileName = openFileDialog.FileName;
                            lbimported.Text = ImportedData.Count.ToString();
                            Isloading = false;
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            MessageBox.Show("Error reading file: " + ex.Message);
                            Isloading = false;
                        }));
                    }
                }).Start();
            }
        }


        private void FrmImport_Load(object sender, EventArgs e)
        {
            ImportedData = new List<Person>();
            this.Text += $" [ {Title} ]";
            Isloading = false;
        }

        private void btncacel_Click(object sender, EventArgs e)
        {
            ImportResult = DialogResult.Cancel;
            Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            ImportResult = DialogResult.OK;
            Close();
        }
    }
}
