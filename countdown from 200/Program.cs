using System;

namespace countdown_from_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countdown from 200!");

            Console.Write("What number would you like to count down by? ");
            int countNumber = int.Parse(Console.ReadLine());

            for (int i = 200; i >= 0; i -= countNumber)
            {
                Console.WriteLine(i);
            }

           
            Console.ReadLine();
        }

       
    }
}
