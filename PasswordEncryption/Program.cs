/*
    Projectname:        PasswordEncryption
    Date:               05.04.2017 11:26
    Autor:              Thorben Jezioro
    VersionNr.:         v.1.0
*/

using System;
using System.Security.Cryptography;

namespace PasswordEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\T. Jezioro\Documents\Visual Studio 2015\Projects\PasswordEncryption\password.txt";
            string hash;

            string password = Gui.ReadPasswordFromUser();

            MD5 md5Hash = Md5Encryption.Md5Creat();
            hash = Md5Encryption.GetMd5Hash(md5Hash, password);
            
            if (IoFile.Exist(path) != true)
            {
                IoFile.WriteAll(path, hash);
                Gui.WriteLine("File created. Password saved.");
            }
            else
            {
                bool checkPassword = ComparisonUtil.CheckPassword(hash, path);
                if (checkPassword == true)
                {
                    Gui.WriteFontGreen("Password is correct");
                }
                else
                {
                    Gui.WriteFontRed("Password is NOT correct");
                }
            }
            Gui.GuiSpace();
            Gui.Write("Please press any key to close this application.");
            Console.ReadKey();
        }        
    }
}