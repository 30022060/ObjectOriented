using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Animal a1 = new Animal();
            Console.Write("Please enter an animal name: ");
            a1.Anml = Console.ReadLine();
            Console.Write("Please enter what sound it makes: ");
            a1.Sound = Console.ReadLine();

            Console.WriteLine("The {0} says '{1}'", a1.Anml, a1.Sound);
            Console.ReadLine();
        }
        class Animal
        {
            private string anml;
            private string sound;

            public string Anml { get { return anml; } set { anml = value; } }
            public string Sound { get { return sound; } set { sound = value; } }
            public Animal() { Console.WriteLine("Creating Animal..."); }
            
        }
        
    }
}
