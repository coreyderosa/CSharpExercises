using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_Stats
{
    class Program
    {
        static void exercise1()
        {
            Console.WriteLine("Enter number of data points: ");
            int dataPoints = Convert.ToInt32(Console.ReadLine());

            //list of numbers
            int[] arr = new int[dataPoints];
            Random num = new Random();
            for (int i = 0; i < dataPoints; i++)
            {
                int a = num.Next(1, 25);
                Console.WriteLine("{0}: {1}", i, a);
                arr[i] = a;
            }

            //median
            Array.Sort(arr);
            double median = new double();
            if(arr.Length % 2 != 0)
            {
                median = arr[arr.Length / 2];
            }
            else
            {
                int middle = arr.Length / 2;
                double first = arr[middle];
                double second = arr[middle - 1];
                median = (first + second) / 2;
            }

            //mode
            var mode = arr.GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .First();

            //standard deviated
            
            double avg = arr.Average();
            var squares = from int value in arr
                            select (value - avg) * (value - avg);
            double sqSum = squares.Sum();
            double modeNum = Math.Sqrt(sqSum / arr.Count() - 1);
                        

            int total = arr.Sum();
            double mean = arr.Average();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Total = {0}", total);
            Console.WriteLine("Mean = {0}", mean);
            Console.WriteLine("Median = {0}", median);
            Console.WriteLine("Mode = {0}", mode);
            Console.WriteLine("Standard Deviation = {0}", modeNum);
            Console.ReadLine();
            
        }
        
        static void Main(string[] args)
        {
            exercise1();
        }
    }
}
