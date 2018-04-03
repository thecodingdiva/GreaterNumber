using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What program would you like to run: \n1) Larger Number \n2) Convert to inches. ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Num();
            }
            else if (input == 2)
            {
                Conversion();
            }
            else
            {
                Console.WriteLine("You did not enter a valid option.");
            }
        }

        static void Num()
        {
            try
            {
                double input1, input2;
                Console.WriteLine("What is your first number: ");
                input1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your second number: ");
                input2 = Convert.ToDouble(Console.ReadLine());

                if (input1 > input2)
                {
                    Console.WriteLine("The max number is " + input1);
                }

                else if (input1 < input2)
                {
                    Console.WriteLine("The max number is " + input2);
                }

                else
                {
                    Console.WriteLine("The numbers are equal");
                }
            }

            catch (System.FormatException e)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            catch(System.IndexOutOfRangeException e1)
            {
                Console.WriteLine("Sorry, your number is to big for me to handle right now.");
            }
        }

        static void Conversion()
        {
            try
            {
                double feet, inches;
                Console.WriteLine("What is your number in feet: ");
                feet = Convert.ToDouble(Console.ReadLine());

                inches = feet * 12;

                if (feet < 0)
                {
                    Console.WriteLine("The number you entered was negative.");
                }
                else
                {
                    if (inches == 1.0)
                    {
                        Console.WriteLine("There are " + inches + " inches in " + feet + " foot.");
                    }
                    else
                    {
                        Console.WriteLine("There are " + inches + " inches in " + feet + " feet.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("You must enter a valid number.");
            }       
        }
    }
}
