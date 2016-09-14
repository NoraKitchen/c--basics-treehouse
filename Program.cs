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
                    try
                    {
                        int minutes = int.Parse(entry);
                        if (minutes <= 0)
                        {
                            Console.WriteLine("Please enter a valid value.");
                            continue;
                        }

                        string message;

                        if (minutes <= 10)
                        {
                            message = "Better than nothing!";
                        }
                        else if (minutes <= 30)
                        {
                            message = "Good job!";
                        }
                        else if (minutes <= 60)
                        {
                            message = "Crazy good.";
                        }
                        else
                        {
                            message = "You're just showing off.";
                        }

                        Console.WriteLine(message);

                        //add minutes exercised to total
                        runningTotal += minutes;

                        //display total min exercised to screen
                        Console.WriteLine("You've exercised " + runningTotal + " minutes");
                        //repeat until user quits
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter a valid value.");
                        continue;
                    }
                } 
                else 
                {
                    keepGoing = false;
                }


            }
        }
    }
}