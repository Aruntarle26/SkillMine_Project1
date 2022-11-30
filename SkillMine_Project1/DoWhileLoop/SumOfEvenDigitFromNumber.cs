using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.DoWhileLoop
{
    class SumOfEvenDigitFromNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            do
            {
                int digit = n % 10;
                if(digit%2==0)
                {
                    sumEven = sumEven + digit;
                }
                n = n / 10;


            } while (n > 0);
            Console.WriteLine("Sum of even Number is: " + sumEven);
        }
    }
}
