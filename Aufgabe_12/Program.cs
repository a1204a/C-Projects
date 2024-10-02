namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Zahl ein.");
            int zahl = Convert.ToInt32(Console.ReadLine());

            while (zahl > 0) 
            {
                zahl--;
                Console.WriteLine($"Die Zahl ist jetzt {zahl}");
            }

        }
    }
}

