using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_WhileLoops
{
    class Program
    {
        static void exercise2()
        {
            int i = 1;
            while (i <= 122)
            {
                Console.Write((char)i + "\t");
                if (i % 10 == 0)
                    Console.Write("\n");
                i++;
            }
            Console.Read();
        }
 
       

        static void exercise1()
        {
            
            string reset = "y";
            Console.WriteLine("What is the command keyword to exit a loop in C#? ");
            Console.WriteLine("A) quit");
            Console.WriteLine("B) continue");
            Console.WriteLine("C) break");
            Console.WriteLine("D) exit");

            
            Console.WriteLine("Enter your answer: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "C" || userAnswer == "c")
                {
                  Console.WriteLine("You are correct!");
                }
            else
            while (reset == "y")
            {  
                Console.WriteLine("Incorrect answer.");
                Console.WriteLine("Try Again?  y/n");
                reset= Console.ReadLine();
                    if (reset == "y")
                    {
                        Console.WriteLine("Enter your answer: ");
                        string userAnswer2 = Console.ReadLine();

                        if (userAnswer2 == "C" || userAnswer2 == "c")
                        {
                            Console.WriteLine("You are correct!");
                            reset = "n";
                        }
                    }
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
