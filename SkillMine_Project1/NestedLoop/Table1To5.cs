using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.Nestedloop
{
    class Table1To5
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
                Console.WriteLine("\t\t");
            }
        }
    }
}
