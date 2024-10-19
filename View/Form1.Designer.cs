namespace TestWithSelenium
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SttCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DobCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDrivers = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listProxyType = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImportProxy = new System.Windows.Forms.Button();
            this.boolProxy = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRSFolder = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.State = new System.Windows.Forms.GroupBox();
            this.lProxy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lFailed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lCreated = new System.Windows.Forms.Label();
            this.NameCreated = new System.Windows.Forms.Label();
            this.lData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrivers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.State.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 20);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.start_BtnClick);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SttCell,
            this.NameCell,
            this.DobCell,
            this.StatusCell});
            this.dataGridView.Location = new System.Drawing.Point(1, 1);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(395, 127);
            this.dataGridView.TabIndex = 1;
            // 
            // SttCell
            // 
            this.SttCell.FillWeight = 50F;
            this.SttCell.HeaderText = "Stt";
            this.SttCell.MinimumWidth = 8;
            this.SttCell.Name = "SttCell";
            // 
            // NameCell
            // 
            this.NameCell.HeaderText = "Name";
            this.NameCell.MinimumWidth = 8;
            this.NameCell.Name = "NameCell";
            // 
            // DobCell
            // 
            this.DobCell.FillWeight = 70F;
            this.DobCell.HeaderText = "Dob";
            this.DobCell.MinimumWidth = 8;
            this.DobCell.Name = "DobCell";
            // 
            // StatusCell
            // 
            this.StatusCell.HeaderText = "Status";
            this.StatusCell.MinimumWidth = 8;
            this.StatusCell.Name = "StatusCell";
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(15, 42);
            this.btnImportData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(86, 32);
            this.btnImportData.TabIndex = 2;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.importData_BtnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numDrivers);
            this.groupBox1.Controls.Add(this.btnImportData);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(115, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Driver";
            // 
            // numDrivers
            // 
            this.numDrivers.Location = new System.Drawing.Point(49, 18);
            this.numDrivers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDrivers.Name = "numDrivers";
            this.numDrivers.Size = new System.Drawing.Size(32, 20);
            this.numDrivers.TabIndex = 4;
            this.numDrivers.ValueChanged += new System.EventHandler(this.numDrivers_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listProxyType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnImportProxy);
            this.groupBox2.Controls.Add(this.boolProxy);
            this.groupBox2.Location = new System.Drawing.Point(122, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(151, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proxy Settings";
            // 
            // listProxyType
            // 
            this.listProxyType.FormattingEnabled = true;
            this.listProxyType.Items.AddRange(new object[] {
            "Http",
            "Socks4",
            "Socks5"});
            this.listProxyType.Location = new System.Drawing.Point(93, 19);
            this.listProxyType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listProxyType.Name = "listProxyType";
            this.listProxyType.Size = new System.Drawing.Size(47, 17);
            this.listProxyType.TabIndex = 5;
            this.listProxyType.SelectedIndexChanged += new System.EventHandler(this.proxyType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            // 
            // btnImportProxy
            // 
            this.btnImportProxy.Location = new System.Drawing.Point(13, 42);
            this.btnImportProxy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportProxy.Name = "btnImportProxy";
            this.btnImportProxy.Size = new System.Drawing.Size(86, 32);
            this.btnImportProxy.TabIndex = 3;
            this.btnImportProxy.Text = "Import Proxy";
            this.btnImportProxy.UseVisualStyleBackColor = true;
            this.btnImportProxy.Click += new System.EventHandler(this.importProxy_BtnClick);
            // 
            // boolProxy
            // 
            this.boolProxy.AutoSize = true;
            this.boolProxy.Location = new System.Drawing.Point(13, 20);
            this.boolProxy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boolProxy.Name = "boolProxy";
            this.boolProxy.Size = new System.Drawing.Size(59, 21);
            this.boolProxy.TabIndex = 0;
            this.boolProxy.Text = "Proxy";
            this.boolProxy.UseVisualStyleBackColor = true;
            this.boolProxy.CheckedChanged += new System.EventHandler(this.proxyChecked_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRSFolder);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(277, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(110, 127);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run";
            // 
            // btnRSFolder
            // 
            this.btnRSFolder.Location = new System.Drawing.Point(21, 91);
            this.btnRSFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRSFolder.Name = "btnRSFolder";
            this.btnRSFolder.Size = new System.Drawing.Size(79, 26);
            this.btnRSFolder.TabIndex = 2;
            this.btnRSFolder.Text = "Rs Folder";
            this.btnRSFolder.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(21, 56);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 26);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // State
            // 
            this.State.Controls.Add(this.lProxy);
            this.State.Controls.Add(this.label3);
            this.State.Controls.Add(this.lFailed);
            this.State.Controls.Add(this.label6);
            this.State.Controls.Add(this.lCreated);
            this.State.Controls.Add(this.NameCreated);
            this.State.Controls.Add(this.lData);
            this.State.Controls.Add(this.label2);
            this.State.Location = new System.Drawing.Point(4, 102);
            this.State.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.State.Name = "State";
            this.State.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.State.Size = new System.Drawing.Size(269, 42);
            this.State.TabIndex = 6;
            this.State.TabStop = false;
            this.State.Text = "State";
            // 
            // lProxy
            // 
            this.lProxy.AutoSize = true;
            this.lProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProxy.Location = new System.Drawing.Point(103, 18);
            this.lProxy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProxy.Name = "lProxy";
            this.lProxy.Size = new System.Drawing.Size(16, 17);
            this.lProxy.TabIndex = 7;
            this.lProxy.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proxy:";
            // 
            // lFailed
            // 
            this.lFailed.AutoSize = true;
            this.lFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFailed.ForeColor = System.Drawing.Color.Red;
            this.lFailed.Location = new System.Drawing.Point(246, 18);
            this.lFailed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFailed.Name = "lFailed";
            this.lFailed.Size = new System.Drawing.Size(16, 17);
            this.lFailed.TabIndex = 5;
            this.lFailed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(205, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Failed:";
            // 
            // lCreated
            // 
            this.lCreated.AutoSize = true;
            this.lCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCreated.ForeColor = System.Drawing.Color.ForestGreen;
            this.lCreated.Location = new System.Drawing.Point(179, 18);
            this.lCreated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCreated.Name = "lCreated";
            this.lCreated.Size = new System.Drawing.Size(16, 17);
            this.lCreated.TabIndex = 3;
            this.lCreated.Text = "0";
            // 
            // NameCreated
            // 
            this.NameCreated.AutoSize = true;
            this.NameCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCreated.ForeColor = System.Drawing.Color.ForestGreen;
            this.NameCreated.Location = new System.Drawing.Point(129, 18);
            this.NameCreated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameCreated.Name = "NameCreated";
            this.NameCreated.Size = new System.Drawing.Size(62, 17);
            this.NameCreated.TabIndex = 2;
            this.NameCreated.Text = "Created:";
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lData.Location = new System.Drawing.Point(43, 18);
            this.lData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(16, 17);
            this.lData.TabIndex = 1;
            this.lData.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data:";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.State);
            this.Settings.Controls.Add(this.groupBox3);
            this.Settings.Controls.Add(this.groupBox2);
            this.Settings.Controls.Add(this.groupBox1);
            this.Settings.Location = new System.Drawing.Point(4, 133);
            this.Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Settings.Size = new System.Drawing.Size(391, 161);
            this.Settings.TabIndex = 7;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 282);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrivers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.State.ResumeLayout(false);
            this.State.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SttCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCell;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDrivers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImportProxy;
        private System.Windows.Forms.CheckBox boolProxy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRSFolder;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox State;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Label lFailed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lCreated;
        private System.Windows.Forms.Label NameCreated;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listProxyType;
        private System.Windows.Forms.Label label4;
    }
}

