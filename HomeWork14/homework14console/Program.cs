﻿using System;

namespace homework14console
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "yes";
            while (input == "yes")
            {
                var koo = 5;
                var kee = 5;
                var maximum = 3;
                var nameKoo = "Mr.Koo";
                var nameKee = "Mr.Kee";

                var numberKoo = koo.ToString();
                var numberKoos = new string('*', koo);

                var numberKee = kee.ToString();
                var numberKees = new string('*', kee);

                System.Console.WriteLine($"Koo ({koo}) :{numberKoos}");
                System.Console.WriteLine($"Kee ({kee}) :{numberKees}");

                for (int i = 0; i < kee || i < koo; i++)
                {
                    Console.Write("Please Input Numbers : ");
                    var num = int.Parse(Console.ReadLine());
                    var isEvenNumber = num % 2 == 0;

                    if (isEvenNumber)
                    {
                        koo -= 1;
                        var countStar = new string('*', koo);
                        System.Console.WriteLine($"Koo ({koo}) :{countStar}");
                        System.Console.WriteLine($"Kee ({kee}) :{numberKees}");
                    }
                    else
                    {
                        kee -= 1;
                        var countStar = new string('*', kee);
                        System.Console.WriteLine($"Koo ({koo}) :{numberKoos}");
                        System.Console.WriteLine($"Kee ({kee}) :{countStar}");
                    }
                }
                if (koo == 0)
                {
                    System.Console.WriteLine($"The Winner is {nameKoo}");
                }
                else
                {
                    System.Console.WriteLine($"The Winner is {nameKee}");
                }
                System.Console.Write("Do you want to try again?: ");
                input = Console.ReadLine();
            }

            System.Console.WriteLine("Good Luck!");
        }
    }
}
