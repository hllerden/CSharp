// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Patika 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world. Wake Up Neo!!");
            Console.WriteLine("İsminizi girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin: ");
            string surname = Console.ReadLine(); 
            Console.WriteLine("Merhaba " + name + "  " + surname);

        }
    }

}
