using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_ConditionalStmts
{
    class Program
    {
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
            exercise1();
        }    
    }
}
