using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_WordGame
{
    class Program
    {

        static void playnext(string[,] terms, int rows)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("\t\t\tENGLISH WORD PREFIX GAME");
            Console.WriteLine("===================================================");

            for (int i = 0; i < rows + 2; i++)
            {
                Console.Write("What is the correct prefix of {0}: ", terms[i, 0]);
                string ans = Console.ReadLine();
                if (terms[i, 1].ToLower().CompareTo(ans.ToString().ToLower()) == 0) terms[i, 2] = "correct";
                Console.WriteLine();
            }


            Console.WriteLine("CHECK YOUR ANSWERS");
            Console.WriteLine("===================================================");
            Console.WriteLine("Word\t\tPrefix\tDescription");
            Console.WriteLine("===================================================");

            for(int i = rows; i < rows + 2; i++)
            {
                for (int j = 0; j < 3; j++)
                Console.Write("{0}\t,", terms[i, j]);
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            string[,] terms = new string[4, 3];
            int row = 0;
            terms[row, 0] = "substring";
            terms[row, 1] = "sub";
            terms[row, 2] = "Incorrect";
            row++;

            terms[row, 0] = "hypertext";
            terms[row, 1] = "hyper";
            terms[row, 2] = "Incorrect";
            row++;

            terms[row, 0] = "antivirus";
            terms[row, 1] = "anti";
            terms[row, 2] = "Incorrect";
            row++;

            terms[row, 0] = "substring";
            terms[row, 1] = "sub";
            terms[row, 2] = "Incorrect";

            int numrows = 0;
            playnext(terms, numrows);
            Console.Write("Next? Press y for next play: ");
            string next = Console.ReadLine();
            if (next.CompareTo("y") == 0)
            {
                Console.Clear();
                numrows += 2;
                playnext(terms, numrows);
            }
            Console.ReadLine();
        }
    }
}
