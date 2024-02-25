using System;
using System.Collections.Concurrent;

namespace module2

{
    public class Task1_5
    {
        public static void Main(string[] args)
        {
            //Task1

            Console.WriteLine("Please give your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please give your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please give your age:");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Please give your sex, please input for female \"k\", for male \"m\":");
            char sex = char.Parse(Console.ReadLine());

            Console.WriteLine("Please give your pesel:");
            string pesel = Console.ReadLine();

            Console.WriteLine("Please give your ID number:");
            string id = Console.ReadLine();

            //Task2

            char characterOne = 'a';
            char characterTwo = 'b';
            char characterThree = 'c';

            Console.WriteLine($"{characterThree},{characterTwo},{characterOne}");

            //Task3
           
            Console.WriteLine("Please give me length of the rectangle a=");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please give me width of the rectangle b=");
            double sideB = double.Parse(Console.ReadLine());

            double diagonal =   Math.Sqrt(Math.Pow(sideA,2)+Math.Pow(sideB,2));
            
            Console.WriteLine($"Diaginal=" + diagonal);

            //Task4

            int a;
            string b;
            float c;
            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5F;

            //Task5

            Console.WriteLine("Please give your first name:");
            string first = Console.ReadLine();

            Console.WriteLine("Please give your last name:");
            string last = Console.ReadLine();

            Console.WriteLine("Please give your number:");
            string number = Console.ReadLine();

            Console.WriteLine("Please give your @:");
            string emial =Console.ReadLine();

            Console.WriteLine("What's your height, please use \"cm\":");
            byte height = byte.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight, please use \"kg\":");
            byte weight = byte.Parse(Console.ReadLine());

        }

    }


}

