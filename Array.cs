using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 90, 50, 10, 100, 3, 85 };
            Console.WriteLine("Array before sorting");
            foreach (int i in x)
                Console.WriteLine(" "+i);
            Console.WriteLine();
            Array.Sort(x); Array.Reverse(x);
            Console.WriteLine("Array after sorting and reversing");
            foreach (int i in x)
                Console.WriteLine(" "+i);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
