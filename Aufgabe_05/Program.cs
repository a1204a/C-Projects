using System.ComponentModel.Design;
using System.Globalization;

namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int km = Convert.ToInt32(Console.ReadLine());

            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht");
                Console.WriteLine("Ende");
            }
            else
            {
                double runden = (double)km / 0.4;
                Console.WriteLine($"Das sind {runden} Runden. Bereit für den Lauf? (ja/nein)");

                string benutzerEingabe = Console.ReadLine();

                if (benutzerEingabe.Equals("ja", StringComparison.OrdinalIgnoreCase))
                {
                    for (int i = 1; i <= runden; i++)
                    {
                        Console.WriteLine($"Du läufst Runde {i}.");
                    }
                    Console.WriteLine("Ende");
                }
                else if (benutzerEingabe.Equals("nein", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Ende");
                }
            }
        }
    }
}

