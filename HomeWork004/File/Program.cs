using System;
using System.IO;

namespace DesktopCleaner
{

    public static class CleanMaster
    {
        static string desktopPath = string.Empty;

        public static void Desktop()
        {
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            foreach (var filr in Directory.GetFiles(desktopPath))
                if (filr.Split('.')[filr.Split('.').Length - 1] != "exe")
                    File.Delete(filr);
            Console.WriteLine("File Deleted!");
        }
        public static void DeleteFrom(string path, string suffix)
        {
            foreach (var f in Directory.GetFiles(path))
                if (f.Split('.')[f.Split('.').Length - 1] == suffix)
                    File.Delete(f);
            Console.WriteLine($"The .{suffix} files are deleted from {path}");
        }
        static void Main(string[] args)
        {
            //Desktop();
            string path = @"C:\Users\Van\Desktop\new";
            DeleteFrom(path, "bmp");
        }
    }
}