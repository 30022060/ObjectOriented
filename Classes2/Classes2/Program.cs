using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Person p1 = new Person();
            Console.Write("Enter First Name: ");
            p1.First = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            p1.Last = Console.ReadLine();
            Console.Write("Enter Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Information Inputted. Displaying...");
            Console.WriteLine("Full Name: {0} {1} \nAge: {2}", p1.First, p1.Last, p1.Age);
            Console.ReadLine();
        }

        
    }
    class Person
    {
        private string first;
        private string last;
        private int age;

        public string First { get { return first; } set { first = value; } }
        public string Last { get { return last; } set { last = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person()
        {
            Console.WriteLine("Object Being Created....\n");
        }
    }
}
