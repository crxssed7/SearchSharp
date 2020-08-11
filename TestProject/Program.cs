using SearchSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = new int[10]
            {
                1,
                3,
                5,
                6,
                7,
                10,
                12,
                14,
                34,
                89,
            };

            Console.WriteLine("Binary Search: " + SearchSharp<int>.Binary(89, data, 0, data.Length));
            Console.WriteLine("Linear Search: " + SearchSharp<int>.Linear(89, data));
            Console.WriteLine("Jump Search: " + SearchSharp<int>.Jump(89, data, 4));
            Console.ReadLine();

        }
    }
}
