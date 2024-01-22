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
        private List<double> values = new List<double>();
        uint threds = (uint)Environment.ProcessorCount;
        Lenguage lenguage = Lenguage.CS;
        string pathToImage;
        string editedPath, basePath;
        MainMechanizm Program;
        public FIltrApp()
        {
            InitializeComponent();
            ThreadLabel.Text = threds.ToString();
        }
        /// <summary>
        /// opening file dialog and saving the path to image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// seeting language to ASM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lenguage = Lenguage.ASM;
        }
        /// <summary>
        /// setting language to CS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lenguage = Lenguage.CS;

        }
        /// <summary>
        /// increment threads number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadLabel.Text = (++threds).ToString();
            }
            catch (Exception E) { return; }
        }
        /// <summary>
        /// decrement threads number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// main program - applying filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = false;
            Program = new MainMechanizm(lenguage);
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
            values.Add(ticks);
            TimeList.Items.Add(ticks.ToString());
            getAverage();
            if (Program.newImagePath != null)
            {
                editImage.ImageLocation = Program.newImagePath;
                editedPath = Program.newImagePath;
                basePath = pathToImage;
                HistogramButton.Enabled = true;
            }
            ConfirmButton.Enabled = true;
        }
        /// <summary>
        /// Action on click, generating new Page with Histograms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// clearing time list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetListButton_Click(object sender, EventArgs e)
        {
            if (TimeList.Items.Count != 0)
            {
                TimeList.Items.Clear();
                values.Clear();
            }
        }
        /// <summary>
        /// after click tthe average button, value is coping into user clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void averageButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(averageButton.Text);
        }
        /// <summary>
        /// counting average value for times in list
        /// </summary>
        private void getAverage()
        {
            double average = values.Count > 0 ? values.Average() : 0;
            averageButton.Text = $"{average:F2}";
        }
        /// <summary>
        /// Generating program 10 times
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit10_Click(object sender, EventArgs e)
        {
            submit10.Enabled = false;
            ConfirmButton.Enabled = false;
            for(int i = 0; i < 10; i++)
            {
                ConfirmButton_Click(sender, e);
            }
            submit10.Enabled = true;
            ConfirmButton.Enabled = true;
        }
    }
}