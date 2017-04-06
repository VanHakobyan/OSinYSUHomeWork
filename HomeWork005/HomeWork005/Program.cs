//Մուտքագրել թղթապանակի անուն, այն դարձել ընթացիկ և 
//պատճենել նրա միջի բոլոր.txt ֆայլերը d:\\007 թղթապանակի մեջ։

using System;
using System.IO;
namespace HomeWork005
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\TestSource";
            string targetPath = @"D:\TestFolder";
            int count = 1;
            foreach (var sourceFilePath in Directory.GetFiles(sourcePath))
            {
                string fileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(targetPath, fileName);
                File.Copy(sourceFilePath, destinationFilePath, true);
                Console.WriteLine($"Copied a {count} file");
                count++;
            }
            Console.WriteLine("\nBeing copied to completed !!!");
            Console.WriteLine($"Total {count} file are Copied !!!\n");



        }
    }
}
