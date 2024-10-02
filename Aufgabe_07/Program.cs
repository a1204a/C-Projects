namespace Aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind:");

            bool firstnumber = true;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (!firstnumber)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i);
                    firstnumber = false;
                }
            }
            Console.WriteLine();
        }
    }
}
