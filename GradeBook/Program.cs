using System;

namespace School
{
    public class GradeBook
    {
        public static string FirstName()
        {
            while (true)
            {
                try
                {
                    Console.Write("please enter first name");
                    string FirstName = Console.ReadLine();
                    return FirstName;
                }
                catch
                {
                    Console.WriteLine("please enter a valid name");
                    continue;
                }
            }
        }

        private static string LastName() { 

            while (true) { 
                try
                {
                    Console.Write("please enter Last name");
                    string LastName = Console.ReadLine();
                    return LastName;
                }
                catch
                {
                    Console.WriteLine("please enter a valid name");
                    continue;
                }
                   
            }
        }


        public static void Main(string[] args)
        {
            string firstName = FirstName();
            string lastName = LastName();

            Console.WriteLine(firstName + " " + lastName);
        }
    }
}

