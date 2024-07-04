using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LeadingEdgeServer.Models.Utilities
{
    public static class MD5CryptoService
    {
        static string hash = "CodeBehindLtd_UserSecret!2345";
        public static string GetEncryptedText(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value)) return null;

                byte[] data = UTF8Encoding.UTF8.GetBytes(value);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transForm = tripDes.CreateEncryptor();
                        byte[] results = transForm.TransformFinalBlock(data, 0, data.Length);
                        var encText = Convert.ToBase64String(results, 0, results.Length);
                        return encText;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to encrypt credentials!");
            }
        }
        public static string GetDecryptedText(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value)) return null;

                byte[] data = Convert.FromBase64String(value);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                                                                                    //Decrypt data by hash key
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to decrypt credentials!");
            }
        }
    }
}
