using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise_variables
{
    class Program
    {
        static void declare()
        {
            int one = 10;
            float two = 12.5f;
            string three = "C# programming";
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.ReadKey();
        }

        static void asterick()
        {
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.ReadKey();
        }

        static void age()
        {
            int age = 20;
            Console.WriteLine("You are {0} years old.", age);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            declare();
            //asterick();
            //age();
        }

    }
}
