using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1
{
    class AreaOfTraingle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base value:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the height value:");
            int h = int.Parse(Console.ReadLine());
            float area = (b * h)/2;
            Console.WriteLine("Area of traigle is : "+area);

        }
    }
}
