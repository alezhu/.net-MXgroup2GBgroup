using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace MXgroup2GBgroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.MySize;
            this.Location = Properties.Settings.Default.MyLoc;
            this.WindowState = Properties.Settings.Default.MyState;
            //            this.tbMaxthon.Text = Properties.Settings.Default.MaxthonPath;
            //            this.tbGB.Text = Properties.Settings.Default.GreenPath;
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            Application.Idle += new EventHandler(this.OnApplicationIdle);
            LoadMaxthonGroups(this.tbMaxthon.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MyState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.MySize = this.Size;
                Properties.Settings.Default.MyLoc = this.Location;
            }
            else
            {
                Properties.Settings.Default.MySize = this.RestoreBounds.Size;
                Properties.Settings.Default.MyLoc = this.RestoreBounds.Location;
            }
            Properties.Settings.Default.Save();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fbdSelectFolder.ShowDialog(this as IWin32Window))
            {
                tbMaxthon.Text = fbdSelectFolder.SelectedPath;
            }
            LoadMaxthonGroups(tbMaxthon.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fbdSelectFolder.ShowDialog(this as IWin32Window))
            {
                tbGB.Text = fbdSelectFolder.SelectedPath;
            }

        }

        public void LoadMaxthonGroups(string folder)
        {
            clbGroups.Items.Clear();
            if (Directory.Exists(folder))
            {
                DirectoryInfo info = new DirectoryInfo(folder);
                FileInfo[] files = info.GetFiles("*.cgp");
                clbGroups.Items.AddRange(files);
            }
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(this.OnApplicationIdle);
        }

        private void OnApplicationIdle(object sender, EventArgs e)
        {
            btnConvert.Enabled = Directory.Exists(tbMaxthon.Text) &&
                Directory.Exists(tbGB.Text) && (clbGroups.CheckedItems.Count > 0);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            pbConvert.Maximum = clbGroups.Items.Count;
            pbConvert.Style = ProgressBarStyle.Continuous;
            foreach (object item in clbGroups.CheckedItems)
            {
                FileInfo info = item as FileInfo;
                NameValueCollection mGroup = LoadMaxthonGroup(info.FullName);
                string outFile = System.IO.Path.Combine(tbGB.Text,info.Name);
                SaveGreenBrowserGroup(outFile,mGroup);
                pbConvert.PerformStep();

            }
            pbConvert.Style = ProgressBarStyle.Marquee;
            pbConvert.Value = 0;
            MessageBox.Show(this as IWin32Window,"All done",this.Text);
        }

        private void SaveGreenBrowserGroup(string p, NameValueCollection mGroup)
        {
            using (StreamWriter writer = new StreamWriter(p,false,Encoding.Default))
            {
                writer.WriteLine("[Group]");
                int index = 0;
                foreach (string key in mGroup.AllKeys)
                {
                    string sIndex = index.ToString();
                    index++;
                    writer.WriteLine("name{0}={1}{2}url{0}={3}", sIndex, key, Environment.NewLine, mGroup[key]);
                }
                writer.Close();
            }
        }

        

        private NameValueCollection LoadMaxthonGroup(string fileName)
        {
            NameValueCollection res = new NameValueCollection();
            using (StreamReader reader = new StreamReader(fileName, Encoding.Default))
            {
                string line = null;
                bool bAdd = false;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (!bAdd)
                    {
                        if (line.StartsWith("[CaptorGroup]"))
                        {
                            bAdd = true;
                        }
                    }
                    else
                    {
                        if (line.StartsWith("["))
                        {
                            break;
                        }
                        int p = line.IndexOf('=');
                        if (p >= 0)
                        {
                            res.Add(line.Substring(0, p), line.Substring(p + 1));
                        }

                    }
                }
                reader.Close();
            }
            return res;
        }

    }
}