using System;

namespace ferdateam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ferda Hoca odev sorgulama sistemi";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sence Ferda Hoca bugun odev verdi mi?");
            Console.ForegroundColor = ConsoleColor.White;
            string verdimi = Console.ReadLine();
            Console.WriteLine("Cevabin " + verdimi + " bakalim dogru mu?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ferda Hoca bugun odev vermedi.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); 
        }
    }
}
