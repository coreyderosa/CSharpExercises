using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise_DoWhileLoops
{
    class Program
    {
        static void exercise2()
        {
            int i = 1;
            do
            {
                Console.Write((char)i + "\t");
                if (i % 10 == 0)
                    Console.Write("\n");
                i++;
            }
            while (i <= 122);

            Console.Read();
        }

        static void exercise1()
        {
            string reset = "y";
            Console.WriteLine("What is the command keyword to exit a loop in C#?");
            Console.WriteLine("A) int");
            Console.WriteLine("B) continue");
            Console.WriteLine("C) break");
            Console.WriteLine("D) exit");
            Console.WriteLine("Enter your answer: ");
            string answer = Console.ReadLine();


                do
                {
                    Console.WriteLine("Enter you answer: ");
                    answer = Console.ReadLine();

                    if (answer == "C" || answer == "c")
                    {
                        Console.WriteLine("Correct!");
                        reset = "y";
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        Console.WriteLine("Try again? y/n");
                        reset = Console.ReadLine();
                    }

                }
                while (reset == "y");
                {

                }
            }
        

        static void Main(string[] args)
        {
            exercise2();
            //exercise1();
        }
    }
}
