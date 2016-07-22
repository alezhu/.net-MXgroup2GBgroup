namespace MXgroup2GBgroup
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
            this.clbGroups = new System.Windows.Forms.CheckedListBox();
            this.fbdSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pbConvert = new System.Windows.Forms.ProgressBar();
            this.tbMaxthon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbGB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbGroups
            // 
            this.clbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clbGroups.CheckOnClick = true;
            this.clbGroups.FormattingEnabled = true;
            this.clbGroups.Location = new System.Drawing.Point(15, 127);
            this.clbGroups.Name = "clbGroups";
            this.clbGroups.Size = new System.Drawing.Size(482, 169);
            this.clbGroups.TabIndex = 0;
            // 
            // pbConvert
            // 
            this.pbConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConvert.Location = new System.Drawing.Point(12, 324);
            this.pbConvert.Name = "pbConvert";
            this.pbConvert.Size = new System.Drawing.Size(485, 23);
            this.pbConvert.Step = 1;
            this.pbConvert.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbConvert.TabIndex = 1;
            // 
            // tbMaxthon
            // 
            this.tbMaxthon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxthon.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MXgroup2GBgroup.Properties.Settings.Default, "MaxthonPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMaxthon.Location = new System.Drawing.Point(15, 25);
            this.tbMaxthon.Name = "tbMaxthon";
            this.tbMaxthon.Size = new System.Drawing.Size(482, 20);
            this.tbMaxthon.TabIndex = 2;
            this.tbMaxthon.Text = global::MXgroup2GBgroup.Properties.Settings.Default.MaxthonPath;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder with Maxthon groups:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(509, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(509, 127);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(509, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbGB
            // 
            this.tbGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MXgroup2GBgroup.Properties.Settings.Default, "GreenPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbGB.Location = new System.Drawing.Point(15, 77);
            this.tbGB.Name = "tbGB";
            this.tbGB.Size = new System.Drawing.Size(482, 20);
            this.tbGB.TabIndex = 2;
            this.tbGB.Text = global::MXgroup2GBgroup.Properties.Settings.Default.GreenPath;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder for Green browser groups:";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(509, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Browse...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maxthon groups list:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 359);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGB);
            this.Controls.Add(this.tbMaxthon);
            this.Controls.Add(this.pbConvert);
            this.Controls.Add(this.clbGroups);
            this.MinimumSize = new System.Drawing.Size(328, 277);
            this.Name = "Form1";
            this.Text = "Maxthon Group To GreenBrowser Group Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbGroups;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectFolder;
        private System.Windows.Forms.ProgressBar pbConvert;
        private System.Windows.Forms.TextBox tbMaxthon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}

