using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Netsalary n1 = new Netsalary();
            Console.Write("Enter Employee's First Name: ");
            fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lname = Console.ReadLine();
            Console.Write("Please Enter the Employee's tax rate: ");
            tax = double.Parse(Console.ReadLine());
            Console.Write("Enter Employee's Annual Wage: ")
            wage = double.Parse(Console.ReadLine());

            Employee p1 = new Employee(fname, lname, tax, wage);

            Console.WriteLine($"Name: {p1.Fname} {p1.Lname}\nTax: {p1.Tax}%\nGross Salary: {p1.Wage}\nNet Salary: {p1.Net()}");
        }
    }

    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double tax { get; set; }
        public double wage { get; set; }

        public Employee(string _fname, string _lname, double _tax, double _wage)
        {
            Fname = _fname;
            Lname = _lname;
            tax = _tax;
            wage = _wage;         
        }
    }

}
