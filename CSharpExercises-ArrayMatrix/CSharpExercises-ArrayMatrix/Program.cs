using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_ArrayMatrix
{
    class Program
    {

        static void exercise1()
        {

            int[,] array = new int[5, 5];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(0); col++)
                {
                    if (col > row)
                    {
                        array[row, col] = 1;
                    }
                    else if (col < row)
                    {
                        array[row, col] = -1;
                    }
                }
            }
            Matrix(array);
        }
        static void Matrix(int[,] fromAbove)
        {
            for (int row = 0; row < fromAbove.GetLength(0); row++)
            {
                for (int col = 0; col < fromAbove.GetLength(1); col++)
                {
                    if (fromAbove[row, col] > -1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(fromAbove[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }



        static void Main(string[] args)
        {
            //exercise2();
            exercise1();
        }
    }
}