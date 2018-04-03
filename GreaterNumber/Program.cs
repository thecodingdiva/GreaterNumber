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
            Num();
        }

        static void Num()
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

            else if(input1 < input2)
            {
                Console.WriteLine("The max number is " + input2);
            }

            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }

        
    }
}
