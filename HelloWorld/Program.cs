using System;

namespace AskName
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            bool status = true;
            double value = 0;
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Give me a list of numbers and I'll add them all together! When you're ready for me to calculate, simply type 'stop'");
            do
            {
                string check = Console.ReadLine(); // sequence check for 'stop'
                if (check == "stop")
                {
                    status = false;
                    break;
                }
                else if (double.TryParse(check, out result)) // if you made it this far you deserve a reward for not cringing
                {
                    value += result; // i dont know what this does sam told me to put this here instead of 1 long line
                }
            } while (status == true);
            Console.WriteLine($"The sum of all numbers you gave me is: {value}");
            Console.ReadKey();
        }
    }
}
