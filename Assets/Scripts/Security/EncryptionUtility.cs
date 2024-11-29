using System;
using System.IO;
using Manager.etc;
using System.Security.Cryptography;
using System.Text;

namespace Security
{
    public class EncryptionUtility : SingletonManagerSystem<EncryptionUtility>
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("HFavB&^*#@FHSIjfFs35JTtcJDgW63nc"); // 32Byte
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("UvNfI4ISy69#&cgq"); // 16Byte

        public static string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create()) // AES 암호화 알고리즘 객체 생성
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }

                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
