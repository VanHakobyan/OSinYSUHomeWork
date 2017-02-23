using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CopyAllToSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Impute file path");
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(Ներմուծեք ֆայլի հասցեն)" + " = ");
            Console.ForegroundColor = ConsoleColor.Red;
            string st = Console.ReadLine();
            //File.ReadAllText(@"D:\text.txt");
            File.Copy(@st, @"D:\CopyText.txt");
            Console.Write("Successful !!!");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("(Կատարված է !!!)");
            Console.ReadKey();
        }
    }
}
