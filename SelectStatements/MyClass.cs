using System;
namespace SelectStatements
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Gam!");
            Console.WriteLine("See if you can guess the correct number!");
            Concole.WriteLine("What is the upper limit for the range of the number?");

            var uppperLimit = int.Parse(Console.ReadLine());

            var random = new Random();
            var number = random.Next(1, uppperLimit);

            Console.WriteLine("Input your guess!");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high! Sorry");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry");
            }
            else
            {
                Console.WriteLine("Correct!!");
            }

        }
    }
}
