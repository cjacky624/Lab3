using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Final
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number between 1-100");
                string userInput = Console.ReadLine(); // reads the next input you put in
                int number = int.Parse(userInput); // parse the userInput to an integer because you can't compare with numbers on a string

                if (number > 100 || number < 1) // this takes care of everything that is not between 1-100
                {
                    Console.WriteLine("Try again");

                }

                else if (number % 2 == 0) // this takes care of all the evens
                {
                    if(number < 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (number <= 60)
                    {
                        Console.WriteLine("Even"); //even and between 26 to 60
                    }
                    
                }

                else if (number % 2 != 0) // odds
                {
                    
                    if (number <= 60)
                    {
                        Console.WriteLine("Odd");
                    }
                    else if (number >= 60)
                    {
                        Console.WriteLine($"{number} Odd"); //$ before quotation marks will print out variable you put in the {} bracketsa
                    }

                }
                Console.WriteLine("Do you want to run the program again? Y/N");
                if(Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
            }
        }
    }
}
