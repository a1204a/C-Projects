using System.Security.Cryptography.X509Certificates;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Prüfen, ob es sich bei einem Jahr um eine schaltjahr handelt. (q to quit)");
                Console.WriteLine(new string('*', 74));
                string? p = Console.ReadLine();

                if (p.ToLower() == "q")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }
                else
                {
                    int i = Convert.ToInt32(p);
                    if (i % 4 == 0 || i % 400 == 0)
                    {
                        Console.WriteLine($"Das Jahr {i} ist ein Schaltjahr.\n");
                    }
                    else
                    {
                        Console.WriteLine($"Das Jahr {i} ist KEIN Schaltjahr.\n");
                    }
                }
            }

        }


    }
}
