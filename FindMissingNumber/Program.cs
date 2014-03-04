using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given an array with inputs from 0 to n with one 
// number missing (so size of array is n - 1) and 
// no repeated numbers. Find the missing number
namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 0, 1, 3 , 2};

            int n = 4;

            Console.WriteLine("Missing number is {0}", FindMissingNumber(input, n));
        }

        // XOR all numbers from 0 to n - x1
        // XOR all numbers in the array - x2
        // missing number x1 XOR x2
        static int FindMissingNumber(int[] input, int n)
        {
            int x1 = 0;

            for (int i = 1; i <= n; i++)
            {
                x1 = x1 ^ i;
            }

            int x2 = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                x2 = x2 ^ input[i];
            }

            return x1 ^ x2;
        }
    }
}
