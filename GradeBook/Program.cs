using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;

namespace School
{
    public class GradeBook
    {
        private static string FullName()
        {
            string FirstName;
            string LastName;
            while (true)
            {
                try
                {
                    Console.Write("please enter first name: ");
                    FirstName = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("please enter a valid name");
                    continue;
                }
                break;
            }

            {

                while (true)
                {
                    try
                    {
                        Console.Write("please enter Last name: ");
                        LastName = Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("please enter a valid name");
                        continue;
                    }
                    break;
                }
            }

            return FirstName + " " + LastName;
        }

        private static int GradeAmount()
        {
            int Num;
            while (true)
            {
                try
                {
                    Console.Write("How many grades are there?: ");
                    Num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Write a valid number");
                    continue;
                }
                break;
            }
            return Num;
        }

        private static List<int> GradeInputs(int gradeAmount)
        {
            List<int> indGrades = new List<int>();
            int i = 0;
            
            while (i < gradeAmount) 
            {
                i++;
                Console.WriteLine(gradeAmount.ToString());
                try
                {
                    Console.Write($"Please insert grade {i}: ");
                    int grade = int.Parse(Console.ReadLine());
                    indGrades.Add(grade);
                }
                catch
                {
                    Console.WriteLine("Please write a valid grade");
                    i--;
                    continue;
                }
            }
            return indGrades;
        }

        private static double average(List<int> grades)
        {
            double ave = 0;
            foreach (int grade in grades) { ave += grade; }
            ave = ave / grades.Count;

            //another way of doing it
            //double ave = grades.Average();
            return ave;
        }

        private static string LetterGrade(double ave)
        {
            if (ave <= 100.00 && ave >= 90.00){return "A";}
            else if (ave <= 89.00 && ave >= 80.00){return "B";}
            else if (ave <= 79 && ave >= 70){return "C";}
            else if (ave <= 69 && ave >= 60){return "D";}
            else{return "F";}
        }

        private static void Display(string fullname, List<int> indGrades, double ave, string letter)
        {
            Console.WriteLine($"The students full name is {fullname}");
            for (int i = 1; i < indGrades.Count; i++)
            {
                Console.WriteLine($"Grade {i} is {indGrades[i]}");
            }
            Console.WriteLine($"Students average is {ave}");
            Console.WriteLine($"The letter grade is {letter}");
        }

        private static void MainMenu()
        {
            int answer;
            while (true)
            {
                Console.WriteLine("<---------------------------------------------------> ");
                Console.WriteLine("                Please pick a number                  ");
                Console.WriteLine("                         /n                           ");
                Console.WriteLine("                         /n                           ");
                Console.WriteLine("                         /n                           ");
                Console.WriteLine("                         /n                           ");
                Console.WriteLine("                         /n                           ");
                Console.WriteLine("                 1. Add a student                     ");
                Console.WriteLine("                 2. see all students                  ");
                Console.WriteLine("                 3. edit a student                    ");
                Console.WriteLine("                 4. Quit                              ");
                Console.WriteLine("                                                      ");
                Console.WriteLine("<---------------------------------------------------> ");
                try
                {
                    Console.Write("         Number: ");
                    answer = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("please put a valid answer");
                    continue;
                }
            }
            switch(answer)
            {
                case 1:
                    Display();
                    break;
                case 2:
                    Console.WriteLine("cominmg soon");
                    break;
                case 3:
                    Console.WriteLine("cominmg soon");
                    break;
                case 4:
                    break;
            }
        }

        public static void Display()
        {
            string fullname = FullName();
            int Gradeamount = GradeAmount();
            List<int> FullGrades = GradeInputs(Gradeamount);
            double ave = average(FullGrades);
            string LetGrade = LetterGrade(ave);
            //string fullname, List<int> indGrades, double ave, string letter
            MainMenu();

        }

        public static void Main(string[] args)
        {
            MainMenu();
        }
    }
}

