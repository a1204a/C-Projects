namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            do
            {
                int number = r.Next(1, 101);
                int guessed = 0;
                int count = 0;

                Console.Clear();
                Console.WriteLine("Deine Zahl (1..100): ");

                do
                {
                    if (int.TryParse(Console.ReadLine(), out guessed))
                    {
                        count++;

                        if (guessed < number)
                            Console.WriteLine("Zahl ist zu klein! Nächster Versuch: ");
                        else if (guessed > number)
                            Console.WriteLine("Zahl ist zu gross! Nächster Versuch: ");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl zwischen 1 und 100 eingeben.");
                    }
                }
                while (guessed != number);

                Console.Write("Die Zahl stimmt! Du hast total " + count + " Versuche benötigt. Noch einmal spielen? [y/n]");
            }
            while (Console.ReadKey(false).Key == ConsoleKey.Y);
        }
    }
}
