

using System.Diagnostics;
using System.Media;
using System.Text;

namespace E_Talon.Forms
{
    internal partial class DisplayWindow : Form
    {
        Instance instance;


        public DisplayWindow(Instance inInstance)
        {
            instance = inInstance;
            InitializeComponent();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            Enabled = false;

            try
            {
                if (ShouldEncrypt())
                {
                    DisplayMessage("Encrypting File Please Wait...", Color.DarkOrange);


                    byte[]? keyFileBytes = instance.ReadFileBytes(keyPicker.FileName);
                    byte[]? targetFileBytes = instance.ReadFileBytes(targetFilePicker.FileName);
                    byte[]? ivBytes = instance.md5.ComputeHash(Encoding.UTF8.GetBytes(ivText.Text));

                    if (keyFileBytes == null) { DisplayMessage("Key file not found.", Color.Red); throw new Exception(); }
                    if (targetFileBytes == null) { DisplayMessage("Target file not found", Color.Red); throw new Exception(); }
                    if (ivBytes == null) { ivBytes = new byte[16]; }

                    byte[] keyHash = instance.GetHashFromFile(keyFileBytes);

                    instance.EncryptFile(targetFilePicker.FileName, instance.hasher.ComputeHash(keyFileBytes), ivBytes);

                    Enabled = true;
                    DisplayMessage("Sucessfully Encrypted File!", Color.Green);
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    DisplayMessage("Decrypting File Please Wait...", Color.DarkOrange);

                    byte[]? keyFileBytes = instance.ReadFileBytes(keyPicker.FileName);
                    byte[]? targetFileBytes = instance.ReadFileBytes(targetFilePicker.FileName);
                    byte[]? ivBytes = instance.md5.ComputeHash(Encoding.UTF8.GetBytes(ivText.Text));

                    if (keyFileBytes == null) { DisplayMessage("Key file not found.", Color.Red); throw new Exception(); }
                    if (targetFileBytes == null) { DisplayMessage("Target file not found", Color.Red); throw new Exception(); }
                    if (ivBytes == null) { ivBytes = new byte[16]; }

                    byte[] keyHash = instance.GetHashFromFile(keyFileBytes);

                    instance.DecryptFile(targetFilePicker.FileName, keyHash, ivBytes);

                    Enabled = true;
                    DisplayMessage("Successfully Decrypted File!", Color.Green);
                    SystemSounds.Exclamation.Play();
                }
            }

            catch
            {
                string message = string.Empty;

                switch (ShouldEncrypt())
                {
                    case true: message = "Error Encrypting"; break;
                    case false: message = "Error Decrypting"; break;
                }

                DisplayMessage(message, Color.Red);
                SystemSounds.Beep.Play();

                Enabled = true;
            }
        }




        public bool ShouldEncrypt()
        {
            if (encryptButton.Checked) { return true; }
            return false;
        }


        public void DisplayMessage(string message, Color textColor)
        {
            messageText.Visible = true;
            messageText.Text = message;
            messageText.ForeColor = textColor;
        }







        private void DisplayWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void selectTargetFileButton_Click(object sender, EventArgs e)
        {
            targetFilePicker.ShowDialog();
        }

        private void selectKeyButton_Click(object sender, EventArgs e)
        {
            keyPicker.ShowDialog();
        }

        private void targetFilePicker_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            targetFilepathText.Text = targetFilePicker.FileName;
        }

        private void keyPicker_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            keyFilepathText.Text = keyPicker.FileName;
        }

        private void DisplayWindow_Load(object sender, EventArgs e)
        {
            MessageBox.Show("!!!WARNING!!!\nThis application encrypts files. There is virtually no way to recover encrypted files without the correct key.\nIt is crucial that you do not lose any key files or you will not be able to recover your file!", "    !!!WARNING!!!");
        }
    }
}
