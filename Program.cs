using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?");
            var choice = Console.ReadLine();

            Animal animal = null;

            animal animal1

            if (choice == "1")
            {
                animal = new Pig();
            }
            else if (choice == "2")
            {
                animal = new Dog();
            }
            else if (choice == "3")
            {
                animal = new Llamma();
            
            }

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
