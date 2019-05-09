using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Car c1 = new Car();
            c1.Make = "Holden";
            c1.Model = "Monaro";
            c1.Colour = "Black";
            Console.WriteLine("Car Type: {0]\nName: {1}\nColour: {2}\nRego {3}", c1.Make, c1.Model, c1.Colour, c1.Rego);
            Console.ReadLine();
        }
    }
    public class Car
    {
        private string make;
        private string model;
        private string colour;
        private int rego;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int Rego
        {
            get { return rego; }
            private set { rego = value; }
        }
        private int RandomRego()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        public Car()
        {
            Console.WriteLine("***Car Created***");
            Rego = RandomRego();
            
        }
    }
}
