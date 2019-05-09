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
            Animal p1 = new Animal();
            Console.Write("Enter Animal: ");
            p1.Type = Console.ReadLine();
            Console.Write("Enter Name: ");
            p1.Name = Console.ReadLine();
            

            Console.WriteLine("Information Inputted. Displaying...");
            Console.WriteLine("Animal: {0} \nName: {1}\n ID: {2}", p1.Type, p1.Name, p1.ID);
            Console.ReadLine();
        }


    }   

    class Animal
    {
        private string type;
        private string name;
        private int id;

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int ID { get { return id; } private set { id = value; } }


        private int RandomId()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        public Animal()
        {
            Console.WriteLine("Object Being Created....\n");
            ID = RandomId();
        }
    }
}