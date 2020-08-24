using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Threading;

namespace Methodsexcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite type of food?");
            string pizzaType = Console.ReadLine();

            Console.WriteLine("What is your weight (in pounds)");
            string weight = Console.ReadLine();

            Console.WriteLine($"There was a human named {userName}, who was {age} years old.");
            Console.WriteLine($"{userName} loved {pizzaType} sooooo much they weighed {weight} pounds.");

            Console.WriteLine();
            Console.WriteLine("I'm gonna ask for two numbers from you...");


            Console.WriteLine("What is the first number you choose, pick a number any number :)");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("And your second number of choice?");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank You!");
            Console.WriteLine();
            int sum = Sum(num1, num2, 10);
            Console.WriteLine($"The sum of your choice plus 10 is {sum}. Math is awesome!");

            Console.WriteLine("That was dope, let's do two more!");
            Console.WriteLine();
            Console.WriteLine("Choose another number...");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("And your last choice of number?");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Groovy!");
            int product = Multiply(num1, num2);
            Console.WriteLine($"{num1} and {num2} multiplied equals {product}");                    
        }
        public static int Sum(params int[] list)
        {
            int sum = 0;
           
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
           
            return sum;
         
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }

}
