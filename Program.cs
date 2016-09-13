using System;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {

            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //prompt user for minutes exercised
                Console.WriteLine("Enter how many minues you exercised. Or type 'quit' to exit: ");
                string entry = Console.ReadLine();

                if (entry != "quit")
                {
                    //add minutes exercised to total
                    runningTotal += int.Parse(entry);

                    //display total min exercised to screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                    //repeat until user quits
                }
            }
        }
    }
}