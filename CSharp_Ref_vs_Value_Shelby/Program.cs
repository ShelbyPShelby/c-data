using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass by VALUE numValue and aValue are different");
            double numValue = 5.0;
            Console.WriteLine($"\n\t numValue now (initial value) is {numValue}");
            doubleByValue(numValue);
            Console.WriteLine($"\n\t numValue now (initial value) is {numValue}");
            doubleByRef(ref numValue);
            Console.WriteLine($"\n\t numValue now (initial value) is {numValue}");
            doubleByRef(ref numValue);
            Console.WriteLine($"\n\t numValue now (initial value) is {numValue}");


            //challenge

            int num1 = 0;
            double num2 = 7,
                   num3 = 4;

            Console.WriteLine($"\nThe initial value for num 1 is {num1}");
            AddByRef(ref num1);
            Console.WriteLine($"Added one by ref, it is now {num1}");

            Console.WriteLine($"\nThe value for num 1 is {num1}");
            SubtractByRef(ref num1);
            Console.WriteLine($"Subtracted by ref, it is now {num1}");


            Console.WriteLine($"\nThe values for [num 2] is {num2} and the value for [num 3] is {num3}\n");
            SwapNum(ref num2, ref num3);
            Console.WriteLine($"After swapping by ref, the values for [num 2] and [num 3] are {num2} and {num3}, respectively");
            
        }

        static void doubleByValue(double aValue)
        {
            aValue *= 2;
            Console.WriteLine($"\n\t aValue is now {aValue}");
        }

        static void doubleByRef(ref double aRef)
        {
            aRef *= 2;
            Console.WriteLine($"\n\t aRef is now {aRef}\n");
        }


        static void SwapNum(ref double one, ref double two)
        {
            double temp = one;

            one = two;

            two = temp;
            

        }

        static void AddByRef(ref int addRef)
        {
            addRef += 1;
            Console.WriteLine($"aRef is now {addRef}");
        }
        static void SubtractByRef(ref int subRef)
        {
            subRef -= 1;
            Console.WriteLine($"aRef is now {subRef}");
        }
    }
}
