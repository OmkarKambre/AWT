using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access_Modifier;

namespace Assembly2
{
    public class student : person
    {
        public int sub1;
        public int sub2;
        public int sub3;
        public student (int id, string name, int age, int sub1 , int sub2 , int sub3) : base (id,name,age)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }
        public double average()
        {
            return (sub1 + sub2 + sub3) / 3.0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(101, "Omkar", 18, 15, 20, 20);
            s1.getP();
            Console.WriteLine("Average Marks: " + s1.average());
            Console.ReadKey();
        }
    }
}
