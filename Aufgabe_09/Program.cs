namespace Aufgabe_09
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
            Console.Write("Zahl: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            int q = BerechneQuersumme(sum);
            Console.WriteLine($"Die Quersumme von {sum} ist: {q}");
        }
    }
}
