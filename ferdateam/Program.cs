using System;
namespace ferdateam
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;
            Console.Title = "Ferda Hoca odev sorgulama sistemi";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sence Ferda Hoca bugun odev verdi mi?");
            Console.ForegroundColor = ConsoleColor.White;
            string verdimi = Console.ReadLine();
            Console.WriteLine("Cevabin " + verdimi + " bakalim dogru mu?");
            Console.ForegroundColor = ConsoleColor.Red;
        if (tarih.DayOfWeek.ToString() == "Friday")
            Console.WriteLine("Ferda Hoca bugun odev verdi. Evet. Maalesef.");
        else 
            Console.WriteLine("Ferda Hoca bugun odev vermedi. Yasasin!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); 
        }
    }
}
