namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[])
        {
            byte month;
            bool eingabe = false;

            while (!eingabe)
            {
                Console.Write("Zahl eingeben (1-12 für Monate): ");
                string input = Console.ReadLine();

                if (byte.TryParse(input, out month))
                {
                    if (month >= 1 && month <= 12)
                    {
                        eingabe = true; // Gültige Eingabe erhalten
                        Console.Write("Monat: ");

                        // Ausgabe des Monatsnamens
                        switch (month)
                        {
                            case 1:
                                Console.WriteLine("Januar");
                                break;
                            case 2:
                                Console.WriteLine("Februar");
                                break;
                            case 3:
                                Console.WriteLine("März");
                                break;
                            case 4:
                                Console.WriteLine("April");
                                break;
                            case 5:
                                Console.WriteLine("Mai");
                                break;
                            case 6:
                                Console.WriteLine("Juni");
                                break;
                            case 7:
                                Console.WriteLine("Juli");
                                break;
                            case 8:
                                Console.WriteLine("August");
                                break;
                            case 9:
                                Console.WriteLine("September");
                                break;
                            case 10:
                                Console.WriteLine("Oktober");
                                break;
                            case 11:
                                Console.WriteLine("November");
                                break;
                            case 12:
                                Console.WriteLine("Dezember");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eingabe ungültig. Geben Sie eine Zahl von 1 bis 12 ein.");
                    }
                }
                else
                {
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültige Zahl ein.");
                }
            }

            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();

        }





    }

}

