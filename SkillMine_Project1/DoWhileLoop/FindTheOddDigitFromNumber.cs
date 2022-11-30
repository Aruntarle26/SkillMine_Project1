using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.DoWhileLoop
{
    class FindTheOddDigitFromNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            do
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    Console.WriteLine("Odd number :" + digit);
                }
                n = n / 10;


            } while (n > 0);
            
        }
    }
}
