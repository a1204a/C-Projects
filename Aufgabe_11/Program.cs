using System.Text.RegularExpressions;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            while (true)
            {
                Console.Write("Geben Sie die Länge der Linie ein: ");
                try
                {
                    length = int.Parse(Console.ReadLine());
                    if (length > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bitte geben Sie eine positive Zahl ein.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                }
            }


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}