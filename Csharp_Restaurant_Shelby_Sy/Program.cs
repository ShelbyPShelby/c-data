using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Restaurant_Shelby_Sy
{
    class Program
    {
        class Food
        {

            public string name { get; set; }
            public double price { get; set; }

            public override string ToString()
            {
                return name + ": $" + price;
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;

            List<Food> menu = new List<Food>();
            List<double> subtotal = new List<double>();

            menu.Add(new Food() { name = "Green Tea", price = 30}); //1
            menu.Add(new Food() { name = "Water", price = 25 });
            menu.Add(new Food() { name = "Pizza", price = 50 });
            menu.Add(new Food() { name = "Steak", price = 10 });
            menu.Add(new Food() { name = "Pasta", price = 30 }); //5
            menu.Add(new Food() { name = "Salad", price = 70 });
            menu.Add(new Food() { name = "Ice Cream", price = 2 });
            menu.Add(new Food() { name = "Cake", price = 15 });
            menu.Add(new Food() { name = "Chicken Strips", price = 60});
            menu.Add(new Food() { name = "Fries", price = 20 }); //10
            menu.Add(new Food() { name = "Mac & Cheese", price = 1 });
            menu.Add(new Food() { name = "Burgers", price = 30 });
            menu.Add(new Food() { name = "Mashed Potatoes", price = 50 });
            menu.Add(new Food() { name = "Coffee", price = 80 });
            menu.Add(new Food() { name = "Salmon", price = 40 }); //15

            SubtotalSum(menu);



        }

        static double SubtotalSum(List<Food> choice)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            int count = 0;
            Console.WriteLine("Welcome to the Dashingly Terrific Market (DTM)!");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Food Desc in choice)
            {
                count++;
                Console.Write($"{count}:");
                Console.WriteLine(Desc.ToString());
            }
            Console.WriteLine("");

            Console.Write("Enter the total number of items you wish to buy: ");
            int itotal = 0,
                iNum = 0; //itotal

            while (!int.TryParse(Console.ReadLine(), out itotal))
            {
                Console.WriteLine("Please enter a valid integer value!");
                Console.WriteLine("Enter the total number of items you wish to buy:");
            }

            double[] ototal = new double[itotal];

            for (int i = 1; i <= itotal; i++) {
                Console.WriteLine($"Enter item number {i}");

                while (!int.TryParse(Console.ReadLine(), out iNum))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                    Console.WriteLine($"Enter item number {i}");
                }

                ototal[i - 1] = choice.ElementAt(iNum-1).price;

                Console.WriteLine($"Your total price is ${ototal.Sum()}.");
            }

            Console.WriteLine("Would you like to remove any items? (Press 1 for no or 2 for yes)");
            int check = 0;

            while (!int.TryParse(Console.ReadLine(), out check))
            {
                Console.WriteLine("Please enter a valid integer value!");
                Console.WriteLine("Would you like to remove any items? (Press 1 for no or 2 for yes)");
            }

            if (check == 1)
            {
                Console.Write("Please enter your total tip: ");
                double tip = 0;
                while(!double.TryParse(Console.ReadLine(), out tip))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                    Console.Write("Please enter your total tip: ");
                }

                double rtotal = (ototal.Sum() + tip) * 1.0825; //real total

                Console.WriteLine($"Your total is {rtotal}");

            }
            else if (check == 2) {
                Console.WriteLine("Enter the amount of items to remove.");
                int amount = 0;
                while (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                    Console.WriteLine("Enter the amount of items to remove.");
                }



                double[] removeItem = new double[amount]; 

                Console.WriteLine("Enter the item(s) you wish to remove in the order they were entered: ");
                int rit; //removed items total
                while (!int.TryParse(Console.ReadLine(), out rit))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                    Console.WriteLine("Enter the item(s) you wish to remove in the order they were entered: ");
                }

                for (int j = 0; j <= amount; j++)
                {
                    Console.Write($"Enter the {j+1} item to be removed: ");
                    int remove = 0;
                    while (!int.TryParse(Console.ReadLine(), out remove))
                    {
                        Console.WriteLine("Please enter a valid integer value!");
                        Console.Write($"Enter the {j+1} item to be removed: ");
                        removeItem[j+1] = choice.ElementAt(remove-1).price; 
                    }
                    Console.WriteLine(removeItem[j-1]);
                }

            }

            return 0;
        }
    }
}