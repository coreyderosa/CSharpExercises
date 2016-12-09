using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_ConditionalStmts
{
    class Program
    {

        static void exercise2()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Please enter the quiz score: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the mid-term score: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the final score: ");
            c = Convert.ToInt32(Console.ReadLine());
            float avg = ((a + b + c) / 3);

            if (avg >= 90)
            {
                Console.WriteLine("Grade is an A");
            }
            else if ((avg >= 80) && (avg < 90))
            {
                Console.WriteLine("Grade is an B");
            }
            else if ((avg >= 70) && (avg < 80))
            {
                Console.WriteLine("Grade is an C");
            }
            else
            {
                Console.WriteLine("Grade is an F");
            }

            Console.Read();
        }

        static void exercise1()
        {

            int a;
            int b;
            int c;

            Console.WriteLine("Please enter your first value: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second value: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your third value: ");
            c = Convert.ToInt32(Console.ReadLine());
            

            if (a > b && a > c)
            {
                Console.WriteLine("Your first value is the greatest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Your second value is the greatest");
            }
            else
            {
                Console.WriteLine("Your third value is the greatest");
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
