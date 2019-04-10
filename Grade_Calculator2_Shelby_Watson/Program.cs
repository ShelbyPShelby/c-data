using System;

namespace Grade_Calculator2_Shelby_Watson
{
    public class Grades
    {

        public string name { get; set; }
        public double grade { get; set; }

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }

        public void SetGrade(double g)
        {
            grade = g;  
        }

        public double GetGrade()
        {
            return grade;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            list<Grades> grades = new list<Grades>();
            int userInput = 0;
            double gradeA = 0;
            string name = "";

            Console.WriteLine("How many Grades");

            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Input your grades");
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("Please enter the assignment name.");
                    name = Console.ReadLine();

                Console.WriteLine("Please enter the grade amount.");
                    while (!double.TryParse(Console.ReadLine(), out gradeA))
                {
                    Console.WriteLine("WARNING, THIS INPUT IS INVALID");
                }
                
               
            }
        }


    }
}