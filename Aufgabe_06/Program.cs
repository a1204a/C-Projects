namespace Aufgabe_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 12));
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine(new string('-', 12));
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
