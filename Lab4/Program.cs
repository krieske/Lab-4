using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            string userChoice;

            while (true)
            {

                Console.WriteLine("Learn your Squares and Cubes!");

                Console.WriteLine("Please enter a a whole number:");
                userNum = int.Parse(Console.ReadLine());

                while (userNum < 0)
                {
                    Console.WriteLine("Please enter a positive number.");
                    userNum = int.Parse(Console.ReadLine());
                }

                // found code for formating on stack overflow, modified it to fit what I needed.
                const string format = "|{0,6} | {1,8} | {2,4}"; // number of column, padding of right edge. minimum numbers used to align.
                Console.WriteLine(string.Format(format, "Number", "Squared", "Cubed"));
                Console.WriteLine(string.Format(format, "------", "--------", "-----")); // minimum amount of dashes used.
                for (int i = 1; i <= userNum; i++)
                {
                    Console.WriteLine(string.Format(format, i, i * i, i * i * i));
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                userChoice = Console.ReadLine();

                if (userChoice == "no" || userChoice == "n") // need more robust validation.
                {
                    break;
                }

            }
        }
    }
}
