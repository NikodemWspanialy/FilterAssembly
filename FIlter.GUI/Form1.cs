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
        string pathToImage = String.Empty;


        public FIltrApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AsmClass = new AsmClass(1, 2, 3);
            AsmClass.Execute();
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
            var Program = new MainMechanizm();
            if (!Program.SetLenguage(lenguage))
            {
                return;
            }
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
            DateTime timeBefore = DateTime.Now;
            Program.run();
            DateTime timeAfter = DateTime.Now;
            var timeEapsed = timeAfter.Subtract(timeBefore);
            TimeList.Items.Add(timeEapsed.ToString());
        }
    }
}