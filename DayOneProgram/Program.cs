using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello " + name + "!");

            Console.WriteLine("Enter two numbers to be added together.");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int finalNumber = (numberOne + numberTwo);

            Console.WriteLine("Your total is "+finalNumber);
                     
        }
    }
}
