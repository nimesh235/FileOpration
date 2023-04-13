using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Internal;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOpration
{
    public partial class Form1 : Form
    {
        private string Name;
        private string DestinationPath;
        private string SourcePath;
        private bool IsLogWrite = false;

        //private Configuration configuration
        //{
        //    get
        //    {
        //        return ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        //    }
        //}
        private LogWriter logWriter
        {
            get
            {
                return new LogWriter();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Name = ConfigurationManager.AppSettings["Name"];
            DestinationPath = ConfigurationManager.AppSettings["DestinationPath"];
            SourcePath = ConfigurationManager.AppSettings["SourcePath"];
            NameBox.Text = Name;
            DestinationtextBox.Text = DestinationPath + "\\" + DateTime.Now.ToString("yyyyMMdd-") + Name;
            SourcePathtextBox.Text = SourcePath;
            IsLogWrite =Boolean.Parse(string.IsNullOrEmpty(ConfigurationManager.AppSettings["IsLogWrite"]) ?"False": ConfigurationManager.AppSettings["IsLogWrite"]);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                List<string> FileList = new List<string>();
                foreach (String file in openFileDialog1.FileNames)
                {
                    FileList.Add(file);
                }
                FilelistView.DataSource = FileList;
            }
            catch (Exception ex)
            {
                if(IsLogWrite)
                    logWriter.LogWrite(ex.Message, LogWriteMode.Error);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void selectfilebutton_Click(object sender, EventArgs e)
        {
            //            this.openFileDialog1.Filter =
            //"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
            //"All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = SourcePath;
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Photos";
            this.openFileDialog1.ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> Files = (List<string>)FilelistView.DataSource;
                if (Files!=null && Files.Count > 0)
                {
                    if (IsLogWrite)
                        logWriter.LogWrite("Start Copy File...", LogWriteMode.Sucsess);
                    foreach (string file in Files)
                    {
                        string destfile = file.Replace(SourcePath, DestinationtextBox.Text);
                        System.IO.FileInfo destfileinfo = new System.IO.FileInfo(destfile);
                        destfileinfo.Directory.Create(); // If the directory already exists, this method does nothing.
                        File.Copy(file, destfile, true);
                        if (IsLogWrite)
                            logWriter.LogWrite(file + " Copy To: " + destfile, LogWriteMode.Sucsess);
                    }

                    if (IsLogWrite)
                        logWriter.LogWrite("Stop Copy File...", LogWriteMode.Sucsess);
                    MessageBox.Show(this, "Copy SucsessFully...", "SucsessFully");
                }
                else
                {
                    MessageBox.Show("Select File First...");
                }
            }
            catch (IOException ex)
            {
                if (IsLogWrite)
                    logWriter.LogWrite(ex.Message, LogWriteMode.Error);
                Console.WriteLine(ex.Message);
            }

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameBox.Text))
            {
                Name = NameBox.Text;
                SetConfigData("Name", Name);
                DestinationtextBox.Text = DestinationPath + "\\" + DateTime.Now.ToString("yyyyMMdd-") + Name;
            }
        }

        private void SourcePathtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SourcePathtextBox.Text))
            {
                SourcePath = SourcePathtextBox.Text;
                SetConfigData("SourcePath", SourcePath);
            }
        }
        private void SetConfigData(string key, string value)
        {
            Configuration configuration=ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
        }
    }
}
