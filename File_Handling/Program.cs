﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fo = new FileStream("C:\\AWT\\demo.txt",FileMode.OpenOrCreate);
            StreamWriter sw= new StreamWriter(fo);
            Console.WriteLine("Enter string to continue or null to exit");
            while(true)
            {
                String str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                    break;
                sw.WriteLine(str);
            }
            sw.Flush();
            fo.Close();

        }
    }
}
