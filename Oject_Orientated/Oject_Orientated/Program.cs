using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oject_Orientated
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            {
                Animal a1 = new Animal();
                a1.Type = "Cat";
                a1.Name = "Obstacle";
                Console.WriteLine("Animal Type: {0}\nName: {1}\nID: {2}", a1.Type, a1.Name, a1.ID);
                Console.ReadLine();
            }
            
        }

            public class Animal
            {
            private string type;
            private string name;
            private int id;

             public string Type
             {
                get { return type; }
                set { type = value; }
             }

             public string Name
             {
                get { return name; }
                set { name = value; }
             }

             public int ID
             {
                get { return id; }
                private set { id = value; }
             }

             private int RandomId()
             {
                Random rand = new Random();
                return rand.Next(1000, 9999);

             }

             public Animal()
             {
                Console.WriteLine("New Animal Created.");
                ID = RandomId();

                Console.ReadLine();
             }

            

            }

    }
}
       

            