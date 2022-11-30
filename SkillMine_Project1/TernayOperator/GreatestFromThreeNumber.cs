using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.TernayOperator
{
    class GreatestFromThreeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number :");
            int c = int.Parse(Console.ReadLine());
            String s=(a>b&&a>c)?a+" is gretest number":(b>a&&b>c)?b+" is Gretest number":c+"is gretest number";
            Console.WriteLine(s);
        }
    }
}
