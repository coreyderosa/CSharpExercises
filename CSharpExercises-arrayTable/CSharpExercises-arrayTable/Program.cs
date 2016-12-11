using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_arrayTable
{
    class Program
    {

        static void exercise1()
        {
            int start = 1;
            int[,] array = new int[5, 5];
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write("{0}\t", start++);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }        


    static void Main(string[] args)
        {
            //exercise2();
            exercise1();
        }
    }
}
