using System;
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

            //----start excercise part 2. ------
        }
        public static int sum(int num1, int num2)
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
