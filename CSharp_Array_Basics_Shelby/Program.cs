//Array Basics
// Shelby Shelby
using System;


namespace CSharp_Array_Basics_Shelby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program to work with arrays in C#");
            //Array -> same data type
            //index start at 0
            //Array with 7 elements
            //Must be given a specific size
            int[] numList = new int[7];

            //add two values
            numList[0] = 75;
            numList[1] = 36;
            //print the values
            Console.WriteLine($"numlist 0: {numList[0]} ");
            Console.WriteLine($"numlist 1: {numList[1]} ");
            //create an array of strings
            string[] people = { "Shelby", "Donna", "My Dude" };

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Person {i}: {people[i]}");
            }

            //array of objects
            object[] interestingArray = { "Dell", 44, 7.55, "ModelX47Y" };
            //display the datatypes and values

            for(int j = 0; j < interestingArray.Length; j++)
            {
                Console.WriteLine($"Interesting Array{j}: Value: {interestingArray[j]} Datatype {interestingArray[j].GetType()}");
            }

            //array sort
            Array.Sort(numList);
            Array.Sort(people);
            //Array.Sort(interestingArray);

            //write a function to print int values in an array
            //function call here to print num list
            PrintIntArray(numList);
            PrintStringArray(people);
            PrintObjectArray(interestingArray);

            Array.Sort(numList);
            Array.Reverse(numList);
            PrintIntArray(numList);

            Array.Sort(people);
            Array.Reverse(people);
            PrintStringArray(people);

            Array.Reverse(interestingArray);
            PrintObjectArray(interestingArray);
        }

        static void PrintIntArray(int[] intArray)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine($"Int Array Value: {k}");
            }
        }

        static void PrintStringArray(string[] stringArray)
        {
            foreach (string k in stringArray)
            {
                Console.WriteLine($"String Array Value: {k}");
            }
        }
        static void PrintObjectArray(object[] objectArray)
        {
            foreach (object k in objectArray)
            {
                Console.WriteLine($"String Object Value: {k}");
            }
        }
    }
}