using System;

namespace MyFirstApp.classes
{
    public class CheckAge
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
    }
}