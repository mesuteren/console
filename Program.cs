﻿using System;

namespace console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
            Console.ReadKey();
        }
    }
}
