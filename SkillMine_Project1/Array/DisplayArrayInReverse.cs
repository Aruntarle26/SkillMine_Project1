using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.Array
{
    class DisplayArrayInReverse
    {
        public void DisplayinReverse(int []a)
        {
            Console.WriteLine("Array in Reverse");
            for (int i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            DisplayArrayInReverse d = new DisplayArrayInReverse();
            d.DisplayinReverse(arr);
        }
    }
}
