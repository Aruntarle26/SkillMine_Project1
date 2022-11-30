using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.Array
{
    class CountOddElement
    {
        public int OddCount(int[] a)
        {
            int count=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array.. ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the  Array Element ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            CountOddElement c = new CountOddElement();
            int count = c.OddCount(a);
            Console.WriteLine("Total odd Element in Array is: " + count);
        }
    }
}
