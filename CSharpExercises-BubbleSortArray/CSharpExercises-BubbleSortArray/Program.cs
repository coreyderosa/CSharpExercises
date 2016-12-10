using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_BubbleSortArray
{
    class Program
    {

        static void exercise1()
        {
            int[] bubble = { 50, 100, 30, 80, 10, 60, 20, 70, 90, 40 };
            int b = 0;

            for (int i = 0; i < bubble.Length; i++)
            {
                for(int j = 0; j < bubble.Length - 1; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        b = bubble[j + 1];
                        bubble[j + 1] = bubble[j];
                        bubble[j] = b;
                    }
                }
            }
            for (int h = 0; h < bubble.Length; h++)
                Console.WriteLine(bubble[h] + " ");

            Console.ReadLine();
        }





        static void Main(string[] args)
        {
            //exercise2();
            exercise1();
        }
    }
}
