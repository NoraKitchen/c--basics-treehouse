using System;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            //prompt user for minutes exercised
            Console.Write("Enter how many minues you exercised: ");

            string entry = Console.ReadLine();
            //add minutes exercised to total
            //display total min exercised to screen
            Console.WriteLine("You've exercised" + entry + "minutes");
            //repeat until user quits
        }
    }
}