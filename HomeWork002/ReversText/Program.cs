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
            Console.Write("Inpute file path - ");
         s: string st = Console.ReadLine();
            string text = string.Empty;
            try
            {
                text = File.ReadAllText(@"C:\Users\Van\Desktop\" + st + ".txt");
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine(f.Message);
                goto s;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message+"input correctly");
                goto s;
            }
           
            List<char> reverseText = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                reverseText.Add(text[text.Length - 1 - i]);
            }
            foreach (var item in reverseText)
            {
                st += item;
            }

            try
            {
                File.WriteAllText(@"C:\Users\Van\Desktop\" + "Reversed" + ".txt", st, Encoding.UTF8);
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine(f.Message);
            }
            finally
            {
                Console.WriteLine();
            }
            
           
            Console.Write("Successful !!!");
            Console.ReadKey();
        }
    }
}
