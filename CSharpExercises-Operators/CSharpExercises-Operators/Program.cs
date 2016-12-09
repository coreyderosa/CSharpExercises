using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_Operators
{
    class Program
    {
        static void output()
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("x value\t\ty value\t\tExpressions\t\tResult");

            Console.WriteLine("{0,-8}\t{1,-8}\tx=y+3\t\t\tx={2,-8}", x, y, y + 3);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=y-2\t\t\tx={2,-8}", x, y, y - 2);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=y*5\t\t\tx={2,-8}", x, y, y * 5);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=x/y\t\t\tx={2,-8}", x, y, (float)x / y);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=x%y\t\t\tx={2,-8}", x, y, x % y);


            Console.Read();

        }

        static void Main(string[] args)
        {
            output();
        }
    }
}
        
    

