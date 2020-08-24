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
            Console.WriteLine ("What is your name?");
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
            
            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum of your choices is {sum}");
        }
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum; 

            //return num1 + num2
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }

}
