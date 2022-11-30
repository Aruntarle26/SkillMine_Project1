using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project1.Array
{
    class DisplayEvenPossitionElement
    {
       
        public void EvenPossition(int[] a)
        {
            Console.WriteLine("Even posstion element are....");
            for (int i = 0; i < a.Length; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
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
            DisplayEvenPossitionElement d = new DisplayEvenPossitionElement();
            d.EvenPossition(arr);





        }
    }
}
