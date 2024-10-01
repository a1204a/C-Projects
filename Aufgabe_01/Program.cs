using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");
            Console.WriteLine();

            //input
            Console.Write("Zahl 1: ");
            int numberone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2: ");
            int numbertwo = Convert.ToInt32(Console.ReadLine());

            //process
            int solution = numberone + numbertwo;

            //output
            Console.Write($"Summe: {solution}");
        }
    }
}
