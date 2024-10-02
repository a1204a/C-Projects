namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Geben Sie eine ganzzahlige Dezimalzahl ein. (q to Quit)");
                string? p = Console.ReadLine();

                if (p.ToLower() == "q")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }

                if (int.TryParse(p, out int n))
                {
                    string bin = "";

                    while (n > 0)
                    {
                        int rest = n % 2;
                        bin = rest + bin;
                        n = n / 2;
                    }
                    Console.WriteLine($"Die Binärdarstellung ist: {bin}.");
                }
            }
        }
    }
}
