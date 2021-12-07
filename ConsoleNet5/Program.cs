using System;

namespace ConsoleNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi girin:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Soyisminizi girin:");
            string lastName = Console.ReadLine();

            string fullName = String.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);
            Console.WriteLine($"İsminizi: {firstName} ve soyisminiz: {lastName}");
        }
    }
}
