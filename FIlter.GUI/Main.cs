using Filter.GUI;
using Filter.GUI.Enum;
using Filter.GUI.Mechanizm;
using FIlter.GUI.Models;
using System.Globalization;
using System.Runtime.InteropServices;


namespace FIlter.GUI
{
    public partial class FIltrApp : Form
    {
        uint threds = (uint)Environment.ProcessorCount;
        Lenguage lenguage = Lenguage.CS;
        string pathToImage;
        string editedPath, basePath;

        public FIltrApp()
        {
            InitializeComponent();
            ThreadLabel.Text = threds.ToString();
        }

        private void FileButtton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.bmp;|jpg Files|*.jpg|bmp Files|*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textLabel.Text = openFileDialog.FileName;
                    pathToImage = openFileDialog.FileName;
                }
                if (pathToImage != null)
                {
                    try
                    {
                        baseImage.ImageLocation = pathToImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lenguage = Lenguage.ASM;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lenguage = Lenguage.CS;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadLabel.Text = (++threds).ToString();
            }
            catch (Exception E) { return; }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (threds > 1)
                {
                    ThreadLabel.Text = (--threds).ToString();

                }
            }
            catch (Exception E) { return; }
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = false;
            var Program = new MainMechanizm(lenguage);
            if (!Program.SetThreds(threds))
            {
                ConfirmButton.Enabled = true;
                return;
            }
            if (!Program.SetImage(pathToImage))
            {
                ConfirmButton.Enabled = true;

                fileErrorLabel.Visible = true;
                return;
            }
            fileErrorLabel.Visible = false;
            var ticks = Program.run();
            TimeList.Items.Add(ticks.ToString());
            if (Program.newImagePath != null)
            {
                editImage.ImageLocation = Program.newImagePath;
                editedPath = Program.newImagePath;
                basePath = pathToImage;
                HistogramButton.Enabled = true;
            }
            ConfirmButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistogramButton.Enabled = false;
            if (editedPath != null && baseImage != null)
            {
                Histogram histogram = new Histogram(basePath, editedPath);
                histogram.Show();
            }
            HistogramButton.Enabled = true;
        }


        private void ResetListButton_Click(object sender, EventArgs e)
        {
            if (TimeList.Items.Count != 0)
            {
                TimeList.Items.Clear();
            }
        }
    }
}