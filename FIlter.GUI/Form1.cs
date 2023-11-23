using Filter.GUI.Enum;
using Filter.GUI.Mechanizm;
using FIlter.GUI.Models;
using System.Globalization;
using System.Runtime.InteropServices;


namespace FIlter.GUI
{
    public partial class FIltrApp : Form
    {
        uint threds = 1;
        Lenguage lenguage = Lenguage.CS;
        string pathToImage = @"C:\Users\nikod\Desktop\ma³pa.jpg";


        public FIltrApp()
        {
            InitializeComponent();
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
            var Program = new MainMechanizm(lenguage);
            if (!Program.SetThreds(threds))
            {
                return;
            }
            if (!Program.SetImage(pathToImage))
            {
                fileErrorLabel.Visible = true;
                return;
            }
            fileErrorLabel.Visible = false;
            var timeElpsed = Program.run();
            TimeList.Items.Add(timeElpsed.ToString());
        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }
    }
}