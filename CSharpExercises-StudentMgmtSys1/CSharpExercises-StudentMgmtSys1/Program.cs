using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_StudentMgmtSys1
{
    class Program
    {
        //Student class
        struct student
        {
            public string stnumber;
            public string stname;
            public string sex;
            public float quiz1;
            public float quiz2;
            public float assignment;
            public float midterm;
            public float final;
            public float total;
        }

        //Menu
        static void displaymenu()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine(" MENU ");
            Console.WriteLine("=============================================================");
            Console.WriteLine("1.Add student records");
            Console.WriteLine("2.Delete student records");
            Console.WriteLine("3.Update student records");
            Console.WriteLine("4.View all student records");
            Console.WriteLine("5.Calculate the average of a selected studnet's scores");
            Console.WriteLine("6.Show student who got the max total score");
            Console.WriteLine("6.Show student who got the min total score");
            Console.WriteLine("8.Find a student by ID");
            Console.WriteLine("9.Sort students by TOTAL score");

        }

        //Add a student record to list
        static void add(student[] st, ref int itemcount)
        {

            Again:
            Console.WriteLine();
            Console.Write("Enter student's ID:");
            st[itemcount].stnumber = Console.ReadLine().ToString();

            if (search(st, st[itemcount].stnumber, itemcount) != -1)
            {

                Console.WriteLine("This ID already exists.");
                goto Again;

            }


            Console.Write("Enter student's Name:");

            st[itemcount].stname = Console.ReadLine().ToString();


            Console.Write("Enter student's Sex(F or M):");
            st[itemcount].sex = Console.ReadLine().ToString();


            Console.Write("Enter student's quizz1 score:");
            st[itemcount].quiz1 = float.Parse(Console.ReadLine());


            Console.Write("Enter student's quizz2 score:");
            st[itemcount].quiz2 = float.Parse(Console.ReadLine());


            Console.Write("Enter student's assigment score:");
            st[itemcount].assignment = float.Parse(Console.ReadLine());


            Console.Write("Enter student's mid term score:");
            st[itemcount].midterm = float.Parse(Console.ReadLine());

            Console.Write("Enter student's final score:");
            st[itemcount].final = float.Parse(Console.ReadLine());

            st[itemcount].total = st[itemcount].quiz1 + st[itemcount].quiz2 + st[itemcount].assignment + st[itemcount].midterm + st[itemcount].final;



            ++itemcount;



        }

        static void viewall(student[] st, int itemcount)
        {
            int i = 0;

            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8}(column index)", "0", "1", "2", "3", "4", "5", "6", "7", "8");
            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8,-5}(column index)", "ID", "NAME", "SEX", "Q1", "Q2", "AS", "MT", "FI", "TOTAL");
            Console.WriteLine("=================================================================");

            while (i < itemcount)
            {
                if (st[i].stnumber != null)
                {
                    Console.Write("{0,-5}{1,-20}{2,-5}", st[i].stnumber, st[i].stname, st[i].sex);
                    Console.Write("{0,-5}{1,-5}{2,-5}", st[i].quiz1, st[i].quiz1, st[i].assignment);
                    Console.Write("{0,-5}{1,-5}{2,-5}", st[i].midterm, st[i].final, st[i].total);
                    Console.Write("\n");
                }
                i = i + 1;
            }
        }

        static int search(student[] st, string id, int itemcount)
        {
            int found = -1;

            for (int i = 0; i < itemcount && found == -1; i++)
            {
                if (st[i].stnumber == id) found = i;
                else found = -1;
            }
            return found;
        }

        static void delete(student[] st, ref int itemcount)
        {
            string id;
            int index;

            if (itemcount > 0)
            {
                Console.WriteLine("Enter student's ID: ");
                id = Console.ReadLine();
                index = search(st, id.ToString(), itemcount);

                if ((index != -1) && (itemcount != 0))
                {
                    if (index == (itemcount - 1))
                    {
                        clean(st, index);
                        --itemcount;
                        Console.WriteLine("The record was deleted.");
                    }
                    else
                    {
                        for (int i = index; i < itemcount - 1; i++)
                        {
                            st[i] = st[i + 1];
                            clean(st, itemcount);
                            --itemcount;
                        }
                    }
                }
                else Console.WriteLine("The record doesn't exist. Check the ID and try again.");
            }
            else Console.WriteLine("No record to delete");
        }

        static void clean(student[] st, int index)
        {
            st[index].stnumber = null;
            st[index].stname = null;
            st[index].sex = null;
            st[index].quiz1 = 0;
            st[index].quiz2 = 0;
            st[index].assignment = 0;
            st[index].midterm = 0;
            st[index].final = 0;
            st[index].total = 0;
        }

        static void update(student[] st, int itemcount)
        {
            string id;
            int column_index;

            Console.Write("Enter student's ID: ");
            id = Console.ReadLine();

            Console.Write("What field do you wish to update? (1-7): ");
            column_index = int.Parse(Console.ReadLine());

            int index = search(st, id.ToString(), itemcount);

            if ((index != -1) && (itemcount != 0))
            {
                if (column_index == 1)
                {
                    Console.WriteLine("Enter student's name: ");
                    st[index].stname = Console.ReadLine().ToString();
                }
                else if (column_index == 2)
                {
                    Console.WriteLine("Enter student's sex (M or F): ");
                    st[index].sex = Console.ReadLine().ToString();
                }
                else if (column_index == 3)
                {
                    Console.WriteLine("Enter student's quiz1 score: ");
                    st[index].quiz1 = float.Parse(Console.ReadLine());
                }
                else if (column_index == 4)
                {
                    Console.WriteLine("Enter student's quiz2 score: ");
                    st[index].quiz2 = float.Parse(Console.ReadLine());
                }
                else if (column_index == 5)
                {
                    Console.WriteLine("Enter student's midterm score: ");
                    st[index].midterm = float.Parse(Console.ReadLine());
                }
                else if (column_index == 6)
                {
                    Console.WriteLine("Enter student's final score: ");
                    st[index].final = float.Parse(Console.ReadLine());
                }
                else if (column_index == 7)
                {
                    Console.WriteLine("Enter student's total: ");
                    st[index].total = float.Parse(Console.ReadLine());
                }
                else Console.WriteLine("Invalid column index");

                st[index].total = st[index].quiz1 + st[index].quiz2 + st[index].midterm + st[index].final;
            }
            else Console.WriteLine("The record doesn't exist. Check the ID and try again.");
        }

        static void average(student[] st, int itemcount)
        {
            string id;
            float avg = 0;

            Console.WriteLine("Enter student's ID: ");
            id = Console.ReadLine();

            int index = search(st, id.ToString(), itemcount);

            if (index != -1 && itemcount > 0)
            {
                st[index].total = st[index].quiz1 + st[index].quiz2 + st[index].midterm + st[index].final;
                avg = (st[index].total) / 5;
            }
            Console.WriteLine("This student's average score is {0}.", avg);
        }

        static void showmax(student[] st, int itemcount)
        {
            float max = st[0].total;
            int index = 0;

            Console.WriteLine(itemcount);

            if (itemcount >= 2)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                {
                    if (max < st[j + 1].total)
                    {
                        max = st[j + 1].total;
                        index = j + 1;
                    }
                    else if (itemcount == 1)
                    {
                        index = 0;
                        max = st[0].total;
                    }
                    else
                    {
                        Console.WriteLine("No record found.");

                        if (index != -1) Console.WriteLine("The student with ID {0} gets the highest score {1}.", st[index].stnumber, max);
                    }
                }
            }
        }

        static void showmin(student[] st, int itemcount)
        {
            float min = st[0].total;
            int index = 0;

            Console.WriteLine(itemcount);

            if (itemcount >= 2)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                {
                    if (min > st[j + 1].total)
                    {
                        min = st[j + 1].total;
                        index = j + 1;
                    }
                    else if (itemcount == 1)
                    {
                        index = 0;
                        min = st[0].total;
                    }
                    else
                    {
                        Console.WriteLine("No record found.");

                        if (index != -1) Console.WriteLine("The student with ID {0} gets the lowest score {1}.", st[index].stnumber, min);
                    }
                }
            }
        }

        static void find(student[] st, int itemcount)
        {
            string id;
            Console.WriteLine("Enter student's ID: ");
            id = Console.ReadLine();

            int index = search(st, id.ToString(), itemcount);
            if (index != 1)
            {
                Console.Write("{0,-5}{1,-20}{2,-5}", st[index].stnumber, st[index].stname, st[index].sex);
                Console.Write("{0,-5}{1,-20}{2,-5}", st[index].quiz1, st[index].quiz1, st[index].assignment);
                Console.Write("{0,-5}{1,-20}{2,-5}", st[index].midterm, st[index].final, st[index].total);
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("The record doesn't exist.");
            }
        }

        //static void find(student[] st, int itemcount)
        //{
        //    string id;
        //    Console.WriteLine("Enter student's ID: ");
        //    id = Console.ReadLine();

        //    int index = search(st, id.ToString(), itemcount);

        //    if (index != -1)
        //    {
        //        Console.WriteLine("{0,-5}{1,-20}{2,-5}", st[index].stnumber, st[index].stname, st[index].sex);
        //        Console.WriteLine("{0,-5}{1,-20}{2,-5}", st[index].quiz1, st[index].quiz1, st[index].assignment);
        //        Console.WriteLine("{0,-5}{1,-20}{2,-5}", st[index].midterm, st[index].final, st[index].total);
        //        Console.WriteLine("\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The record doesn't exist.");
        //    }
        //}

        static void bubblesort(student[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++) ;
            for (j = n; j > i; j--) ;

            if (dataset[j].total < dataset[j - 1].total)
            {
                student temp = dataset[j];
                dataset[j] = dataset[j - 1];
                dataset[j - 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                student[] st = new student[20];
                int itemcount = 0;
                displaymenu();
                int yourchoice;
                string confirm;

                do
                {
                    Console.Write("Enter your choice (1-8): ");
                    yourchoice = int.Parse(Console.ReadLine());

                    switch (yourchoice)
                    {
                        case 1:
                            add(st, ref itemcount);
                            break;
                        case 2:
                            delete(st, ref itemcount);
                            break;
                        case 3:
                            update(st, itemcount);
                            break;
                        case 4:
                            viewall(st, itemcount);
                            break;
                        case 5:
                            average(st, itemcount);
                            break;
                        case 6:
                            showmax(st, itemcount);
                            break;
                        case 7:
                            showmin(st, itemcount);
                            break;
                        case 8:
                            find(st, itemcount);
                            break;
                        case 9:
                            bubblesort(st, itemcount);
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;

                    }
                    Console.WriteLine("Press y or Y to continue.");
                    confirm = Console.ReadLine().ToString();

                } while (confirm == "y" || confirm == "Y");
            }
            catch (FormatException f) { Console.WriteLine("Invalid input"); }
            Console.Read();
        }

    }
    
}



