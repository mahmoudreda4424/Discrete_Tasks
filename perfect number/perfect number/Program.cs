using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("enter the firt number: ");
               int number1=int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");

            int number2 =int.Parse(Console.ReadLine());
            Console.WriteLine("The perfect number between " + number1 + " and " + number2 + " is :");

            for (int i = number1; i < number2; i++)
                {
                    if (Perfect(i) && i!=0)
                        Console.WriteLine(i );
                }

                Console.ReadLine();
            }


            static bool Perfect(int number)
            {
                int sum = 0;
                for (int j = 1; j < number; j++)
                {
                    if (number % j == 0)
                        sum += j;
                }

                return sum == number;
            
        }
    }
}
