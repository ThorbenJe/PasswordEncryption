/*
    Projectname:        PasswordEncryption - Md5Encryption
    Date:               05.04.2017 11:26
    Autor:              Thorben Jezioro
    VersionNr.:         v.1.0
*/

using System;
using System.Text;
using System.Security.Cryptography;

namespace PasswordEncryption
{
    class Md5Encryption
    {
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static void VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = Md5Encryption.GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        }
        public static MD5 Md5Creat()
        {
            MD5 md5Hash = MD5.Create();
            return md5Hash;
        }
    }
}
