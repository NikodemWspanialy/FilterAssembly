namespace FIlter.GUI
{
    partial class FIltrApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIltrApp));
            openFileDialog = new OpenFileDialog();
            FileButtton = new Button();
            textLabel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            LenguegeBox = new GroupBox();
            AddButton = new Button();
            MinusButton = new Button();
            ThreadLabel = new Label();
            ConfirmButton = new Button();
            fileErrorLabel = new Label();
            baseImage = new PictureBox();
            editImage = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TimeList = new ListView();
            HistogramButton = new Button();
            ResetListButton = new Button();
            averageButton = new Button();
            label1 = new Label();
            LenguegeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)baseImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            resources.ApplyResources(openFileDialog, "openFileDialog");
            // 
            // FileButtton
            // 
            resources.ApplyResources(FileButtton, "FileButtton");
            FileButtton.BackColor = Color.Khaki;
            FileButtton.Name = "FileButtton";
            FileButtton.UseVisualStyleBackColor = false;
            FileButtton.Click += FileButtton_Click;
            // 
            // textLabel
            // 
            resources.ApplyResources(textLabel, "textLabel");
            textLabel.Name = "textLabel";
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // LenguegeBox
            // 
            resources.ApplyResources(LenguegeBox, "LenguegeBox");
            LenguegeBox.Controls.Add(radioButton2);
            LenguegeBox.Controls.Add(radioButton1);
            LenguegeBox.Name = "LenguegeBox";
            LenguegeBox.TabStop = false;
            // 
            // AddButton
            // 
            resources.ApplyResources(AddButton, "AddButton");
            AddButton.Name = "AddButton";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MinusButton
            // 
            resources.ApplyResources(MinusButton, "MinusButton");
            MinusButton.Name = "MinusButton";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // ThreadLabel
            // 
            resources.ApplyResources(ThreadLabel, "ThreadLabel");
            ThreadLabel.Name = "ThreadLabel";
            // 
            // ConfirmButton
            // 
            resources.ApplyResources(ConfirmButton, "ConfirmButton");
            ConfirmButton.BackColor = Color.Khaki;
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // fileErrorLabel
            // 
            resources.ApplyResources(fileErrorLabel, "fileErrorLabel");
            fileErrorLabel.ForeColor = Color.Red;
            fileErrorLabel.Name = "fileErrorLabel";
            // 
            // baseImage
            // 
            resources.ApplyResources(baseImage, "baseImage");
            baseImage.Name = "baseImage";
            baseImage.TabStop = false;
            // 
            // editImage
            // 
            resources.ApplyResources(editImage, "editImage");
            editImage.Name = "editImage";
            editImage.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(ThreadLabel);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // TimeList
            // 
            resources.ApplyResources(TimeList, "TimeList");
            TimeList.BackColor = Color.Khaki;
            TimeList.Name = "TimeList";
            TimeList.UseCompatibleStateImageBehavior = false;
            TimeList.View = View.List;
            // 
            // HistogramButton
            // 
            resources.ApplyResources(HistogramButton, "HistogramButton");
            HistogramButton.BackColor = Color.Khaki;
            HistogramButton.Name = "HistogramButton";
            HistogramButton.UseVisualStyleBackColor = false;
            HistogramButton.Click += button1_Click;
            // 
            // ResetListButton
            // 
            resources.ApplyResources(ResetListButton, "ResetListButton");
            ResetListButton.BackColor = Color.Khaki;
            ResetListButton.Name = "ResetListButton";
            ResetListButton.UseVisualStyleBackColor = false;
            ResetListButton.Click += ResetListButton_Click;
            // 
            // averageButton
            // 
            resources.ApplyResources(averageButton, "averageButton");
            averageButton.BackColor = Color.Khaki;
            averageButton.Name = "averageButton";
            averageButton.UseVisualStyleBackColor = false;
            averageButton.Click += averageButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // FIltrApp
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 255, 204);
            Controls.Add(label1);
            Controls.Add(averageButton);
            Controls.Add(ResetListButton);
            Controls.Add(HistogramButton);
            Controls.Add(TimeList);
            Controls.Add(groupBox2);
            Controls.Add(editImage);
            Controls.Add(baseImage);
            Controls.Add(fileErrorLabel);
            Controls.Add(ConfirmButton);
            Controls.Add(MinusButton);
            Controls.Add(AddButton);
            Controls.Add(LenguegeBox);
            Controls.Add(textLabel);
            Controls.Add(FileButtton);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FIltrApp";
            LenguegeBox.ResumeLayout(false);
            LenguegeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)baseImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)editImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private Button FileButtton;
        private Label textLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox LenguegeBox;
        private Button AddButton;
        private Button MinusButton;
        private Label ThreadLabel;
        private Button ConfirmButton;
        private Label fileErrorLabel;
        private PictureBox baseImage;
        private PictureBox editImage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView TimeList;
        private Button HistogramButton;
        private Button ResetListButton;
        private Button averageButton;
        private Label label1;
    }
}