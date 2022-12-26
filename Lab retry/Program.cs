using System;

namespace Lab_retry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ikireqemli eded daxil edin");
            string input = Console.ReadLine();
            if (input.Length < 2 || input.Length > 2)
            {
                Console.WriteLine("Eded ikireqemli deyil");
                return;
            }
            int number = int.Parse(input);
            int lastDigit = number % 10;
            number /= 10;
            Console.WriteLine($"{number} {lastDigit}");
        
                
        }
    }
}
