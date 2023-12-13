using System;
using System.Net.Mail;

namespace tydzień2zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello1!");
            Console.WriteLine("Odpowiedz proszę na pytania");
            Console.WriteLine("Imię:");
            string imię;
            imię = Console.ReadLine();

            Console.WriteLine("Nazwisko:");
            string nazwisko;
            nazwisko = Console.ReadLine();

            Console.WriteLine("Numer telefonu:");
            string numerTelefonu;
            numerTelefonu = Console.ReadLine();

            Console.WriteLine("Adres email");
            string AdresEmail;
            AdresEmail = Console.ReadLine();

            Console.WriteLine("Wzrost");
            int wzrost;
            wzrost = int.Parse(Console.ReadLine());

            Console.WriteLine("Waga");
            double waga;
            waga = double.Parse(Console.ReadLine());

        }
    }
}