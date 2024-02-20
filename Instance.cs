using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using E_Talon.Forms;

namespace E_Talon
{
    internal class Instance : ApplicationContext
    {
        DisplayWindow displayWindow;

        Aes aes = Aes.Create();
        internal SHA256 hasher = SHA256.Create();
        internal MD5 md5 = MD5.Create();


        public Instance()
        {
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;

            displayWindow = new DisplayWindow(this);
            Start();
        }


        public void Start() { displayWindow.Show(); Debuger(); }


        public void Debuger()
        {
            byte[] outs = hasher.ComputeHash(Encoding.UTF8.GetBytes("bungo"));
            Debug.WriteLine(outs.Length);
        }



        public async Task EncryptFile(string targetFilePath, byte[] key, byte[] iv)
        {
            try
            {
                aes.Key = key;
                aes.IV = iv;

                byte[] fileBytes = ReadFileBytes(targetFilePath)!;

                using (ICryptoTransform encryptor = aes.CreateEncryptor(key, aes.IV))
                {
                    byte[] outFileBytes = encryptor.TransformFinalBlock(fileBytes, 0, fileBytes.Length);

                    await File.WriteAllBytesAsync(targetFilePath, outFileBytes);
                }

                aes.GenerateKey(); // Clears the key from the algorithm
            }

            catch (Exception ex)
            {
                Debug.WriteLine($"Error encrypting file. Message:\n{ex.Message}");
            }
        }

        public async Task DecryptFile(string targetFilePath, byte[] key, byte[] iv)
        {
            try
            {
                byte[] eFileBytes = await File.ReadAllBytesAsync(targetFilePath);

                using (ICryptoTransform decryptor = aes.CreateDecryptor(key, iv))
                {
                    byte[] dFileBytes = decryptor.TransformFinalBlock(eFileBytes, 0, eFileBytes.Length);

                    await File.WriteAllBytesAsync(targetFilePath, dFileBytes);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine($"Error Decrypting File! Message:\n{ex.Message}");
            }
        }



        // Get byte data from specified filepath
        public byte[]? ReadFileBytes(string filePath)
        {
            if (!File.Exists(filePath)) { return null; }

            byte[] readBytes = File.ReadAllBytes(filePath);
            return readBytes;
        }


        // Get Hashed bytes from in byte array
        public byte[] GetHashFromFile(byte[] inBytes) { return hasher.ComputeHash(inBytes); }


        // Stop application
        public void Stop() { Application.Exit(); }
    }
}
