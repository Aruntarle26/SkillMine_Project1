using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.DoWhileLoop
{
    class SumOf1stAndLastDigitFromNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int lastDigit;
            int firstDigit;
            do
            {
                 lastDigit = n % 10;
                break;
            } while (n > 0);
            do
            {
                 firstDigit = n % 10;
                n = n / 10;
            } while (n > 0);
            int sum = firstDigit + lastDigit;
            Console.WriteLine("Sum of First and Last digit is: "+sum);
        }
    }
}
