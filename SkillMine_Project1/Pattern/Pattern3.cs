﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.Pattern
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows?");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    // Console.Write("* ");
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
