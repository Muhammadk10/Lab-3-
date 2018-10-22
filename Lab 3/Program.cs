
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            bool shouldContinue;

            {

                Console.WriteLine("Enter a number between 1-100 ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                
                do
                {
                    if (userNumber % 2 == 1)
                    {
                        Console.WriteLine(userNumber + " " + "You number is odd ");

                    }
                    else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine(userNumber + " " + "Your number is even and less then 25 ");
                    }
                    else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine("Your number is even");

                    }
                    else if (userNumber % 2 == 0 && userNumber >= 60)
                    //     else if()
                    {
                        Console.WriteLine(userNumber + " " + "is even");

                    }
                    else if (userNumber % 2 == 1 && userNumber >= 60)
                    {
                        Console.WriteLine(userNumber + " " + "is odd");

                    }

                    Console.WriteLine("\nWould you like to continue ? [y/n]");



                    if (Console.ReadLine() == "y")
                    {
                        shouldContinue = true;
                    }
                    else
                    {
                        shouldContinue = false;
                    }

                } while (shouldContinue == true);
                   
                Console.ReadKey();
                

            }

        }
    }
}




