﻿using System;
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
            //File.ReadAllText(@"D:\text.txt");
            File.Copy(@"D:\text.txt", @"D:\CopyText.txt");
        }
    }
}
