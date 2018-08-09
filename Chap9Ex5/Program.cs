using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that checks whether an element, from a certain position
            // in an array is greater than its two neighbors. Test whether the
            // method works correctly.
            int[] testArr = { 1, 2, 3, 4, 2, 7, 5, 2, 3 };
            int position = 5;
            Console.WriteLine(IsElementGreater(testArr, position));
            Console.ReadLine();

        }

        static bool IsElementGreater(int[] inputArr, int position)
        {
            if (inputArr[position] > inputArr[position - 1] && inputArr[position] > inputArr[position + 1])
            {
                return true;
            }
            else return false;
        }
    }
}
