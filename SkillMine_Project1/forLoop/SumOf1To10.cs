using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.forLoop
{
    class SumOf1To10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
               
            }
            Console.WriteLine("Sum of 1 to 10 is: "+sum);
        }
    }
}
