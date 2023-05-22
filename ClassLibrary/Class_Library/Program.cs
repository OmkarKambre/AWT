using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Class_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the String: ");
                string inp = Console.ReadLine();
                if (string.IsNullOrEmpty(inp)) break;
                Console.WriteLine($"Input:{inp}");
                Console.WriteLine($"Begins with uppercase?{(inp. StartsWithUpper() ? "Yes":"No")}");
            }
        }
    }
}
