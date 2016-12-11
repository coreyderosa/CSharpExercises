using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise_SearchingArrays
{
    class Program
    {
        static void exercise2()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int find;
            int answer;

            Console.WriteLine("Enter a value: ");
            answer = Convert.ToInt32(Console.ReadLine());
            find = seqSearch(numbers, answer);

            if (find == -1)
            {
                Console.WriteLine("Could not find " + answer + " in the array.");
            }
            else
            {
                Console.WriteLine("Found " + answer + " in the array at location " + (find + 1));
            }
            Console.ReadLine();
        }

        static int seqSearch(int[] array, int value)
        {
            int min = 0;
            int n = array.Length;
            int max = n - 1;

            do
            {
                int mid = (min + max) / 2;
                if (value > array[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (array[mid] == value)
                    return mid;
            }

            while (min <= max);
            {
                return -1;
            }
        }


        //    static void exercise1()
        //{
        //    int[] numbers = { 50, 100, 30, 80, 10, 60, 20, 70, 90, 40 };
        //    int find;
        //    int answer;

        //    Console.WriteLine("Enter a value: ");
        //    answer = Convert.ToInt32(Console.ReadLine());
        //    find = seqSearch(numbers, answer);

        //    if (find == -1)
        //    {
        //        Console.WriteLine("Could not find " + answer + " in the array.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Found " + answer + " in the array at location " + (find + 1));
        //    }
        //    Console.ReadLine();
        //}

        //static int seqSearch(int [] array, int value)
        //{
        //    int index;
        //    int element;
        //    Boolean found;

        //    index = 0;

        //    element = -1;
        //    found = false;

        //    while(!found && index < array.Length)
        //    {
        //        if(array[index] == value)
        //        {
        //            found = true;
        //            element = index;
        //        }
        //        index++;
        //    }
        //    return element;


        //}



        static void Main(string[] args)
        {
            exercise2();
            //exercise1();
        }
    }
}
