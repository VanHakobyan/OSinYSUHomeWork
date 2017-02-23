using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Upper_case
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string st = File.ReadAllText(@"D:\text.txt");
            Console.WriteLine("all text");
            Console.WriteLine();
            Console.WriteLine(st);
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Only Upper");
            Console.WriteLine();
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= 'A' && st[i] <= 'Z')
                    Console.Write(st[i]+" ");
            }
        }
    }
}
