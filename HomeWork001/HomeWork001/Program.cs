using System;
using System.IO;

namespace HomeWork001
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDir = @"f:\current";
            string backupDir = @"f:\archives";

            try
            {
                string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

                foreach (string f in picList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }
                foreach (string f in txtList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);
                    try
                    {
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }
                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }
                foreach (string f in txtList)
                {
                    File.Delete(f);
                }
                foreach (string f in picList)
                {
                    File.Delete(f);
                }
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ձեր ֆայլերը հաջողությամբ տեղափոխվել են !!!");
            Console.ReadKey();
        }
    }
}
