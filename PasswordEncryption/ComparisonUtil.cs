/*
    Projectname:        PasswordEncryption - ComparisonUtil
    Date:               05.04.2017 11:26
    Autor:              Thorben Jezioro
    VersionNr.:         v.1.0
*/

using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace PasswordEncryption
{
    class ComparisonUtil
    {
        public static bool CheckPassword(string hash, string path)
        {
            string filePassword = IoFile.readAll(path);
            if (filePassword != hash)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
