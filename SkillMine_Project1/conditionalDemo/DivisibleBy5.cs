using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.conditionalDemo
{
    class DivisibleBy5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            if(n%5==0)
                Console.WriteLine(n +" is divisible by 5");
            else
                Console.WriteLine(n + " is  Not divisible by 5");

        }
       
    }
}
