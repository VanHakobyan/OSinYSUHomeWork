using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Reversing VH";
            Console.SetWindowSize(30, 10);
            Console.Write("Impute file path - ");
            string st = Console.ReadLine();
            string text = string.Empty;
            text = File.ReadAllText(@"C:\Users\Van\Desktop\" + st + ".txt");
            List<char> reverseText = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                reverseText.Add(text[text.Length - 1 - i]);
            }
            foreach (var item in reverseText)
            {
                st += item;
            }
            File.WriteAllText(@"C:\Users\Van\Desktop\" + "Reversed" + ".txt", st, Encoding.UTF8);
            Console.WriteLine();
            Console.Write("Successful !!!");
            Console.ReadKey();
        }
    }
}
