/*
    Projectname:        PasswordEncryption - IoFile Class
    Date:               05.04.2017 11:26
    Autor:              Thorben Jezioro
    VersionNr.:         v.1.0
*/

using System.IO;

namespace PasswordEncryption
{
    class IoFile
    {
        public static bool Exist(string path)
        {
            if (File.Exists(path) == true)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public static void WriteAll(string path, string hash)
        {
            File.WriteAllText(path, hash);
        }

        public static string readAll(string path)
        {
            string filePassword = File.ReadAllText(path);
            return filePassword;
        }
    }
}
