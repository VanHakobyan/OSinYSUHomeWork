using System;
using System.IO;
using System.Threading;

namespace _DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data and Time now - " + DateTime.Now);
            string path = Console.ReadLine();
            Console.WriteLine("Last Access Time  - " + File.GetLastAccessTimeUtc(@path));
            Console.WriteLine("changed date and time stile now");
            File.SetCreationTime(@path, DateTime.Now);
            Thread.Sleep(1000);
            Console.WriteLine(File.GetLastAccessTimeUtc(@path));

        }
    }
}
