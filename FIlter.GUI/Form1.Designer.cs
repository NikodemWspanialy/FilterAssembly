namespace FIlter.GUI
{
    partial class Form1
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
            button1 = new Button();
            openFileDialog = new OpenFileDialog();
            FileButtton = new Button();
            FileLabel = new Label();
            textLabel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            LenguegeBox = new GroupBox();
            DebugLenguageLabel = new Label();
            AddButton = new Button();
            MinusButton = new Button();
            ThreadLabel = new Label();
            ConfirmButton = new Button();
            label1 = new Label();
            fileErrorLabel = new Label();
            LenguegeBox.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(532, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // FileButtton
            // 
            FileButtton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FileButtton.Location = new Point(32, 26);
            FileButtton.Name = "FileButtton";
            FileButtton.Size = new Size(153, 50);
            FileButtton.TabIndex = 2;
            FileButtton.Text = "Choose file";
            FileButtton.UseVisualStyleBackColor = true;
            FileButtton.Click += FileButtton_Click;
            // 
            // FileLabel
            // 
            FileLabel.Location = new Point(0, 0);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(100, 23);
            FileLabel.TabIndex = 0;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(205, 48);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(27, 15);
            textLabel.TabIndex = 3;
            textLabel.Text = "%%";
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
            LenguegeBox.Location = new Point(32, 114);
            LenguegeBox.Name = "LenguegeBox";
            LenguegeBox.Size = new Size(200, 108);
            LenguegeBox.TabIndex = 6;
            LenguegeBox.TabStop = false;
            LenguegeBox.Text = "Lenguage";
            // 
            // DebugLenguageLabel
            // 
            DebugLenguageLabel.AutoSize = true;
            DebugLenguageLabel.Location = new Point(238, 177);
            DebugLenguageLabel.Name = "DebugLenguageLabel";
            DebugLenguageLabel.Size = new Size(38, 15);
            DebugLenguageLabel.TabIndex = 7;
            DebugLenguageLabel.Text = "label1";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(51, 255);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(19, 23);
            AddButton.TabIndex = 8;
            AddButton.Text = "W";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(51, 286);
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
            ThreadLabel.Location = new Point(86, 255);
            ThreadLabel.Name = "ThreadLabel";
            ThreadLabel.Size = new Size(45, 54);
            ThreadLabel.TabIndex = 10;
            ThreadLabel.Text = "1";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(32, 358);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(75, 23);
            ConfirmButton.TabIndex = 11;
            ConfirmButton.Text = "Wyślij";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // fileErrorLabel
            // 
            fileErrorLabel.AutoSize = true;
            fileErrorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fileErrorLabel.ForeColor = Color.Red;
            fileErrorLabel.Location = new Point(35, 79);
            fileErrorLabel.Name = "fileErrorLabel";
            fileErrorLabel.Size = new Size(194, 25);
            fileErrorLabel.TabIndex = 13;
            fileErrorLabel.Text = "Bład wyboru pliku!!!";
            fileErrorLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fileErrorLabel);
            Controls.Add(label1);
            Controls.Add(ConfirmButton);
            Controls.Add(ThreadLabel);
            Controls.Add(MinusButton);
            Controls.Add(AddButton);
            Controls.Add(DebugLenguageLabel);
            Controls.Add(LenguegeBox);
            Controls.Add(textLabel);
            Controls.Add(FileLabel);
            Controls.Add(FileButtton);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            LenguegeBox.ResumeLayout(false);
            LenguegeBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog;
        private Button FileButtton;
        private Label FileLabel;
        private Label textLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox LenguegeBox;
        private Label DebugLenguageLabel;
        private Button AddButton;
        private Button MinusButton;
        private Label ThreadLabel;
        private Button ConfirmButton;
        private Label label1;
        private Label fileErrorLabel;
    }
}