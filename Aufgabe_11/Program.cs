namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lange soll deine Lienie sein?");
            Console.Write("Deine Eingabe: ");

            int länge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('*', länge));
        }
    }
}
