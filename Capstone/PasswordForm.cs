using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Net.NetworkInformation;

namespace Capstone
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Length == 0)
            {
                PasswordCheck.Enabled = false;
            }

            else
            {
                PasswordCheck.Enabled = true;
            }
        }

        AESEncrypt Crypt = new AESEncrypt();
        public string TypedPassword;

        private void PasswordCheck_Click(object sender, EventArgs e)
        {
            TypedPassword = Crypt.AESEncrypt256(Encoding.UTF8.GetBytes(PasswordBox.Text), NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString()).ToString();

            if (TypedPassword == MainForm.GetPassword)
            {
                Hide();
                PasswordBox.Clear();
            }

            else
            {
                MessageBox.Show("올바르지 않은 암호 입니다. ", "잘못된 입력", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotClose(object sender, FormClosingEventArgs e)
        {
            PasswordBox.Clear();
            Hide();
            e.Cancel = true;
        }
    }

    public class AESEncrypt
    {
        private SHA512Managed sha512Managed = new SHA512Managed();
        private RijndaelManaged aes = new RijndaelManaged();

        public AESEncrypt()
        {
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
        }

        public byte[] AESEncrypt256(byte[] encryptData, string password)
        {
            var salt = sha512Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));

            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA512);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            byte[] xBuff = null;

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(encryptData, 0, encryptData.Length);
                }
                xBuff = ms.ToArray();
            }

            return xBuff;
        }
    }
}