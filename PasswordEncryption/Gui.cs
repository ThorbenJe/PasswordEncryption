/*
    Projectname:        PasswordEncryption - Gui
    Date:               05.04.2017 11:26
    Autor:              Thorben Jezioro
    VersionNr.:         v.1.0
*/

using System;

namespace PasswordEncryption
{
    static class Gui
    {
        public static string ReadPasswordFromUser()
        {
            System.Console.Write("Please enter a password: ");
            string password = Console.ReadLine();
            Gui.GuiSpace();
            return password;
        }
        public static void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
        public static void Write(string text)
        {
            System.Console.Write(text);
        }
        public static void ResetColor()
        {
            System.Console.ResetColor();
        }
        public static void WriteFontRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Gui.WriteLine(text);
            Gui.ResetColor();
        }
        public static void WriteFontGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Gui.WriteLine(text);
            Gui.ResetColor();
        }
        public static void GuiSpace()
        {
            Gui.WriteLine("");
        }
    }
}
