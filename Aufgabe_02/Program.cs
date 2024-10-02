using System;

namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[])
        {
            Console.WriteLine();
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage.");
            Console.WriteLine(new string('-', 80));

            int days = 0; 
            bool eingabe = false;

            while (!eingabe)
            {
                Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out days))
                {
                    if (days >= 28 && days <= 31)
                    {
                        eingabe = true; 
                    }
                    else
                    {
                        Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl zwischen 28 und 31 ein.");
                    }
                }
                else
                {
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültige Zahl ein.");
                }
            }

            long seconds = days * 24 * 60 * 60;
            Console.WriteLine($"Die Anzahl der Sekunden in einem Monat mit {days} Tagen beträgt {seconds} Sekunden.");

            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
}
