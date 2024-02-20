namespace E_Talon.Forms
{
    partial class DisplayWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            keyPicker = new OpenFileDialog();
            panel1 = new Panel();
            decryptButton = new RadioButton();
            encryptButton = new RadioButton();
            keyFilepathText = new TextBox();
            selectKeyButton = new Button();
            targetFilepathText = new TextBox();
            selectTargetFileButton = new Button();
            messageText = new Label();
            submitButton = new Button();
            targetFilePicker = new OpenFileDialog();
            ivText = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // keyPicker
            // 
            keyPicker.Title = "Select Key FIle";
            keyPicker.FileOk += keyPicker_FileOk;
            // 
            // panel1
            // 
            panel1.Controls.Add(decryptButton);
            panel1.Controls.Add(encryptButton);
            panel1.Location = new Point(12, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 61);
            panel1.TabIndex = 0;
            // 
            // decryptButton
            // 
            decryptButton.AutoSize = true;
            decryptButton.Font = new Font("Segoe UI", 12F);
            decryptButton.Location = new Point(3, 28);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(82, 25);
            decryptButton.TabIndex = 1;
            decryptButton.TabStop = true;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            // 
            // encryptButton
            // 
            encryptButton.AutoSize = true;
            encryptButton.Font = new Font("Segoe UI", 12F);
            encryptButton.Location = new Point(3, 3);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(80, 25);
            encryptButton.TabIndex = 0;
            encryptButton.TabStop = true;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            // 
            // keyFilepathText
            // 
            keyFilepathText.Font = new Font("Segoe UI", 12F);
            keyFilepathText.Location = new Point(104, 62);
            keyFilepathText.Name = "keyFilepathText";
            keyFilepathText.ReadOnly = true;
            keyFilepathText.ShortcutsEnabled = false;
            keyFilepathText.Size = new Size(300, 29);
            keyFilepathText.TabIndex = 1;
            // 
            // selectKeyButton
            // 
            selectKeyButton.Font = new Font("Segoe UI", 11F);
            selectKeyButton.Location = new Point(12, 62);
            selectKeyButton.Name = "selectKeyButton";
            selectKeyButton.Size = new Size(86, 29);
            selectKeyButton.TabIndex = 2;
            selectKeyButton.Text = "Select Key";
            selectKeyButton.UseVisualStyleBackColor = true;
            selectKeyButton.Click += selectKeyButton_Click;
            // 
            // targetFilepathText
            // 
            targetFilepathText.Font = new Font("Segoe UI", 12F);
            targetFilepathText.Location = new Point(104, 7);
            targetFilepathText.Name = "targetFilepathText";
            targetFilepathText.ReadOnly = true;
            targetFilepathText.ShortcutsEnabled = false;
            targetFilepathText.Size = new Size(300, 29);
            targetFilepathText.TabIndex = 3;
            // 
            // selectTargetFileButton
            // 
            selectTargetFileButton.Font = new Font("Segoe UI", 11F);
            selectTargetFileButton.Location = new Point(9, 7);
            selectTargetFileButton.Name = "selectTargetFileButton";
            selectTargetFileButton.Size = new Size(86, 29);
            selectTargetFileButton.TabIndex = 4;
            selectTargetFileButton.Text = "Target File";
            selectTargetFileButton.UseVisualStyleBackColor = true;
            selectTargetFileButton.Click += selectTargetFileButton_Click;
            // 
            // messageText
            // 
            messageText.AutoSize = true;
            messageText.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            messageText.Location = new Point(12, 166);
            messageText.Name = "messageText";
            messageText.Size = new Size(126, 25);
            messageText.TabIndex = 5;
            messageText.Text = "Message Text";
            messageText.Visible = false;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline);
            submitButton.Location = new Point(319, 171);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(85, 39);
            submitButton.TabIndex = 6;
            submitButton.Text = "Go";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // targetFilePicker
            // 
            targetFilePicker.FileOk += targetFilePicker_FileOk;
            // 
            // ivText
            // 
            ivText.Location = new Point(104, 116);
            ivText.Name = "ivText";
            ivText.PlaceholderText = "Injection Vector";
            ivText.Size = new Size(97, 23);
            ivText.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(103, 142);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 8;
            label1.Text = "(Optional)";
            // 
            // DisplayWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 222);
            Controls.Add(label1);
            Controls.Add(ivText);
            Controls.Add(submitButton);
            Controls.Add(messageText);
            Controls.Add(selectTargetFileButton);
            Controls.Add(targetFilepathText);
            Controls.Add(selectKeyButton);
            Controls.Add(keyFilepathText);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DisplayWindow";
            ShowIcon = false;
            Text = "E Talon";
            FormClosed += DisplayWindow_FormClosed;
            Load += DisplayWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog keyPicker;
        private Panel panel1;
        private RadioButton decryptButton;
        private RadioButton encryptButton;
        private TextBox keyFilepathText;
        private Button selectKeyButton;
        private TextBox targetFilepathText;
        private Button selectTargetFileButton;
        private Label messageText;
        private Button submitButton;
        private OpenFileDialog targetFilePicker;
        private TextBox ivText;
        private Label label1;
    }
}