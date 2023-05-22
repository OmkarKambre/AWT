using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manopulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Omkar";
            int lenght = name.Length;
            Console.WriteLine(lenght);

            //Console.WriteLine($"CharArraytoString={name}");
            char[] ch = name.ToCharArray();
            for(int i = 0;i < name.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

            string name2 = "Kabir";
            string con_name = string.Concat(name, name2);
            Console.WriteLine(con_name);

            bool name_equal = string.Equals(name, name2);
            Console.WriteLine(name_equal);

            int com_name = string.Compare(name, name2);    
            Console.WriteLine(com_name);

            int index_name = name2.IndexOf('a');
            Console.WriteLine(index_name);

            string join_name = string.Join("",name, name2);
            Console.WriteLine(join_name);

            string str = "Welcome to C# Programming";
            string[] seprator = { " " };
            int count = 3;
            string[] strlist = str.Split(seprator, count, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in strlist)
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();
        }
    }
}
