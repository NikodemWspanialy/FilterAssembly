using Filter.GUI.Enum;
using FIlter.GUI.Models;
using System.Runtime.InteropServices;


namespace FIlter.GUI
{
    public partial class Form1 : Form
    {
        uint threds = 1;
        Lenguage lenguage = Lenguage.CS;
        string pathToImage = String.Empty;


        public Form1()
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
            DebugLenguageLabel.Text = "ASM";
            lenguage = Lenguage.ASM;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DebugLenguageLabel.Text = "C#";
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
            var Program = new PropertiesModel();
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
            Program.run();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}