using System;

namespace GradeCalculator_Shelby_Watson
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            Console.WriteLine("How many Grades would you like to enter?");

            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid Input. Please enter a valid number.");
            }

            double[] grades = new double[userInput];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Please input your grade.");
                while (!double.TryParse(Console.ReadLine(), out grades[i])) 
                    
            {
                    Console.ForegroundColor = ConsoleColor.Red;    
                Console.WriteLine("Invalid Input. Please enter a valid number.");
                    Console.ResetColor();
            }
                if(grades[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WARNING, THIS IS AN INVALID INPUT");
                    Console.ResetColor();
                    i--;
                }
            }
            Console.WriteLine("Least to Greatest");
            Array.Sort(grades);
            PrintGrades(grades);

            Console.WriteLine("Greatest to Least");
            Array.Reverse(grades);
            PrintGrades(grades);

            Console.WriteLine("Average:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(AverageGrades(grades, userInput));
            Console.ResetColor();
        }

        static double AverageGrades(double[] grad, int gpa)
        {
            double Avg = 0;
            for(int i = 0; i < gpa; i++)
            {
                Avg += grad[i];
            }
            Avg = Avg / gpa;
            return Avg;
        }

        static void PrintGrades(double[] gra)
        {
            foreach(double k in gra)
            {
                Console.WriteLine(k);
            }
        }
    }
}