using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    internal class Program
    {
        public class person
        {
            public int id;
            public string name;
            public int age; 
            public person(int id, string name, int age)
            {
                this.id = id;
                this.name = name;
                this.age = age;
            }
            public void getP()
            {
                Console.WriteLine("Id: " + this.id + "\n Name: " + this.name + "\n Age: " + this.age);
            }
        }

        internal class program
        {
            static void Main(string[] args)
            {
                Console.ReadKey();
            }
        }
    }
}
