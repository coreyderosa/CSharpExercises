using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_randomNumber
{
    class Program
    {
        static void exercise2()
        {
            string reset = "y";
            Random umm = new Random();
            int a = umm.Next(1, 7);

            do
            {
                Console.WriteLine("Guess a number between 1 and 6!");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a)
                {
                    Console.WriteLine("Nice guess!!!");
                    reset = "n";
                }
                else
                {
                    Console.WriteLine("Nice try but no cigar!");
                    Console.WriteLine("The correct number is {0}. Better luck next time.", a);
                    Console.WriteLine("Try again? y/n");
                    reset = Console.ReadLine();
                }
            }
            while (reset == "y");
            

        }


        static void exercise1()
        {
            Random umm = new Random();
            int a = umm.Next(1, 7);
            Console.WriteLine("Guess a number between 1 and 6!");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == a)
            {
                Console.WriteLine("Nice guess!!!");
            }
            else
            {
                Console.WriteLine("Nice try but no cigar!");
                Console.WriteLine("The correct number is {0}. Better luck next time.", a);
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
