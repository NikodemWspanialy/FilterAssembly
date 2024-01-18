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
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
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
            var timeElpsed = Program.run();
            var seconds = timeElpsed.Seconds;
            var miliseconds = timeElpsed.Milliseconds;
            var item = seconds.ToString() + ".";
            if (miliseconds >= 100)
            {
                item = item + miliseconds.ToString();
            }
            else if (miliseconds >= 10)
            {
                item = item + "0" + miliseconds.ToString();
            }
            else
            {
                item = item + "00" + miliseconds.ToString();
            }
            TimeList.Items.Add(item.ToString());
            if (Program.newImagePath != null)
            {
                editImage.ImageLocation = Program.newImagePath;
            }
            ConfirmButton.Enabled = true;

        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FIltrApp_Load(object sender, EventArgs e)
        {

        }

        private void fileErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void ThreadLabel_Click(object sender, EventArgs e)
        {

        }
    }
}