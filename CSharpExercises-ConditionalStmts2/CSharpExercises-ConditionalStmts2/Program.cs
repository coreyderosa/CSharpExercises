﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_ConditionalStmts2
{
    class Program
    {

        static void exercise2()
        {
            char PEOTUS;
            Console.WriteLine("Who is the current President-Elect of the United States of America? \nA)Barack Obama \nB)Hilary Clinton \nC)Donald Trump");
            PEOTUS = Convert.ToChar(Console.ReadLine());
            switch (PEOTUS)
            {
                case 'A':
                    Console.WriteLine("Wrong answer!");
                    break;
                case 'a':
                    Console.WriteLine("Wrong answer!");
                    break;
                case 'B':
                    Console.WriteLine("Wrong answer!");
                    break;
                case 'b':
                    Console.WriteLine("Wrong answer!");
                    break;
                case 'C':
                    Console.WriteLine("You are correct!");
                    break;
                case 'c':
                    Console.WriteLine("You are correct!");
                    break;
                default:
                    Console.WriteLine("Choose A, B or C");
                    break;
            }

            Console.Read();

        }

        static void exercise1()
        {
            char numberKey;
            Console.WriteLine("Please enter in a number 0-9:");
            numberKey = Convert.ToChar(Console.ReadLine());
            switch (numberKey)
            {
                case '0':
                    Console.WriteLine("You entered 0");
                    break;
                case '1':
                    Console.WriteLine("You entered 1");
                    break;
                case '2':
                    Console.WriteLine("You entered 2");
                    break;
                case '3':
                    Console.WriteLine("You entered 3");
                    break;
                case '4':
                    Console.WriteLine("You entered 4");
                    break;
                case '5':
                    Console.WriteLine("You entered 5");
                    break;
                case '6':
                    Console.WriteLine("You entered 6");
                    break;
                case '7':
                    Console.WriteLine("You entered 7");
                    break;
                case '8':
                    Console.WriteLine("You entered 8");
                    break;
                case '9':
                    Console.WriteLine("You entered 9");
                    break;
                default:
                    Console.WriteLine("You did not enter a number!");
                    break;
            }

            Console.Read();
        }


        static void Main(string[] args)
        {
            exercise2();
            //exercise1();
        }
    }
}
