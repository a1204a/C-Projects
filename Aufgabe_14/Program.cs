using System.Security.Cryptography.X509Certificates;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int stammBreite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes? ");
            int stammHoehe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int kronenHoehe = Convert.ToInt32(Console.ReadLine());

            ZeichneBaum(stammHoehe, stammBreite, kronenHoehe);

            Console.ReadKey();
        }
        static void ZeichneBaum(int stammHoehe, int stammBreite, int kronenHoehe)
        {
            ZeichneKrone(kronenHoehe);
            ZeichneStamm(stammHoehe, stammBreite, kronenHoehe);
        }
        static void ZeichneStamm(int stammHoehe, int stammBreite, int kronenHoehe)
        {
            for (int i = 0; i <= stammHoehe; i++)
            {
                int anzLeer = (kronenHoehe - 1) - (stammBreite / 2);
                ZeichneZeile(anzLeer, stammBreite);
            }
        }
        static void ZeichneKrone(int kronenHoehe)
        {
            int anzSterne = 1;
            int anzLeer = kronenHoehe - 1;

            for (int i = 1; i <= kronenHoehe; i++)
            {
                ZeichneZeile(anzLeer, anzSterne);
                anzSterne += 2;
                anzLeer -= 1;
            }
        }
        static void ZeichneZeile(int anzahlLeerzeichen, int anzahlSterne)
        {
            Console.WriteLine();

            for (int i = 1; i <= anzahlLeerzeichen; i++)
                Console.Write(" ");

            for (int i = 1; i <= anzahlSterne; i++)
                Console.Write("*");
        }
    }
}      