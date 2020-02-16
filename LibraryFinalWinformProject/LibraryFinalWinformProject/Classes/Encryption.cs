using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LibraryFinalWinformProject.Classes
{
    public class Encryption
    {
        public static string four = "laksykoiam8pl9zx";
        public static string key = "aqw7palmanasasln24aslas9aw1pl0ai";
        public static string Encrypt(string decrypted)
        {
            byte[] txtbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = ASCIIEncoding.ASCII.GetBytes(key);
            encdec.IV = ASCIIEncoding.ASCII.GetBytes(four);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);
            byte[] enc = icrypt.TransformFinalBlock(txtbytes, 0, txtbytes.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }
        public static string Decrypt(string encrypted)
        {
            byte[] encbytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = ASCIIEncoding.ASCII.GetBytes(key);
            encdec.IV = ASCIIEncoding.ASCII.GetBytes(four);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);
            byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
            icrypt.Dispose();
            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}
