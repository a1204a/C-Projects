namespace Aufgabe_10
{
    internal class Program
    {
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while (zahl > 0)
            {
                sum += zahl % 10;
                zahl /= 10;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl 1:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl, Quersumme, Zahl/Quersumme");

            for (int i = zahl1; i <= zahl2; i++)
            {

                int q = BerechneQuersumme(i);

                if (q != 0 && i % q == 0)
                {
                    Console.WriteLine($"{i}, {q}, {i / q}");
                }
            }

        }


    }
}