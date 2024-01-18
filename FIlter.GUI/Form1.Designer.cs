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
            LenguegeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)baseImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // FileButtton
            // 
            FileButtton.BackColor = Color.Khaki;
            FileButtton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FileButtton.Location = new Point(20, 37);
            FileButtton.Name = "FileButtton";
            FileButtton.Size = new Size(144, 39);
            FileButtton.TabIndex = 2;
            FileButtton.Text = "Choose file";
            FileButtton.UseVisualStyleBackColor = false;
            FileButtton.Click += FileButtton_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(23, 77);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(12, 15);
            textLabel.TabIndex = 3;
            textLabel.Text = "*\r\n";
            textLabel.Visible = false;
            textLabel.Click += textLabel_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(19, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 25);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "C#";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(19, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 25);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Assembler";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // LenguegeBox
            // 
            LenguegeBox.Controls.Add(radioButton2);
            LenguegeBox.Controls.Add(radioButton1);
            LenguegeBox.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LenguegeBox.Location = new Point(11, 115);
            LenguegeBox.Name = "LenguegeBox";
            LenguegeBox.Size = new Size(153, 108);
            LenguegeBox.TabIndex = 6;
            LenguegeBox.TabStop = false;
            LenguegeBox.Text = "Lenguage";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(20, 252);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(19, 23);
            AddButton.TabIndex = 8;
            AddButton.Text = "W";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(20, 279);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(19, 23);
            MinusButton.TabIndex = 9;
            MinusButton.Text = "M";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // ThreadLabel
            // 
            ThreadLabel.AutoSize = true;
            ThreadLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ThreadLabel.Location = new Point(44, 21);
            ThreadLabel.Name = "ThreadLabel";
            ThreadLabel.Size = new Size(45, 54);
            ThreadLabel.TabIndex = 10;
            ThreadLabel.Text = "1";
            ThreadLabel.Click += ThreadLabel_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Khaki;
            ConfirmButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmButton.Location = new Point(11, 308);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(153, 32);
            ConfirmButton.TabIndex = 11;
            ConfirmButton.Text = "Wyślij";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // fileErrorLabel
            // 
            fileErrorLabel.AutoSize = true;
            fileErrorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fileErrorLabel.ForeColor = Color.Red;
            fileErrorLabel.Location = new Point(23, 79);
            fileErrorLabel.Name = "fileErrorLabel";
            fileErrorLabel.Size = new Size(112, 25);
            fileErrorLabel.TabIndex = 13;
            fileErrorLabel.Text = "Error in file";
            fileErrorLabel.Visible = false;
            fileErrorLabel.Click += fileErrorLabel_Click;
            // 
            // baseImage
            // 
            baseImage.Location = new Point(280, 26);
            baseImage.MaximumSize = new Size(128, 128);
            baseImage.Name = "baseImage";
            baseImage.Size = new Size(128, 128);
            baseImage.SizeMode = PictureBoxSizeMode.Zoom;
            baseImage.TabIndex = 15;
            baseImage.TabStop = false;
            baseImage.Click += pictureBox1_Click;
            // 
            // editImage
            // 
            editImage.Location = new Point(280, 177);
            editImage.MaximumSize = new Size(128, 128);
            editImage.Name = "editImage";
            editImage.Size = new Size(121, 128);
            editImage.SizeMode = PictureBoxSizeMode.Zoom;
            editImage.TabIndex = 16;
            editImage.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ThreadLabel);
            groupBox1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(153, 76);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Threads";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(185, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(85, 315);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "results";
            // 
            // TimeList
            // 
            TimeList.BackColor = Color.Khaki;
            TimeList.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TimeList.Location = new Point(194, 63);
            TimeList.Margin = new Padding(0);
            TimeList.Name = "TimeList";
            TimeList.RightToLeft = RightToLeft.Yes;
            TimeList.Size = new Size(68, 277);
            TimeList.TabIndex = 14;
            TimeList.UseCompatibleStateImageBehavior = false;
            TimeList.View = View.List;
            // 
            // FIltrApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 255, 204);
            ClientSize = new Size(452, 450);
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
            Name = "FIltrApp";
            Text = "Filtr Biało Czarny";
            Load += FIltrApp_Load;
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
    }
}