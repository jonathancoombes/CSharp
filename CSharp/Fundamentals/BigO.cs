using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ConsoleApp.Fundamentals
{

    //The following BigO class aims to demonstrate the main Big O runtime examples and concepts to understand

    class BigO
    {

        // O(1)
        // Explanation: Runs in constant time
        // Example
        public void BigO1(int[] nums)
        {
            WriteLine(nums[0]);
        }

        // O(Log n)
        // Explanation: Runs on logarithmic time. Complexity reduces each time it runs.
        // Example of this is a binary search function:
        // Based only on sorted elements, the binary search starts at the middle of the collection, compares the value sought(x)
        // with the number in the middle of the collection, if the middle number is the number(x) sought, return. If not, therefore if it(x) is
        // is smaller than the middle number, delete the top half and get the middle of the remainder of the array and continue.

        // Example:

        public bool BigOLogN(int num, int[] setNums)
        {
            int midPoint = setNums.Length / 2;
            int ops = 0;

            while (setNums[midPoint] != num)
            {
                if (num < setNums[midPoint])
                {
                    midPoint /= 2;
                }
                else
                {
                    midPoint = (midPoint - setNums.Length) / 2;
                }
            }
            Console.WriteLine($"Value found at position: {midPoint}");
            Console.WriteLine($"The search took: {ops} operations");

            return midPoint == num;
        }
        

        // O(n)
        // Explanation: Runs in linear time. Grows in linear time in accordance with input size.
        // Example
        public void BigOn(int[] nums)
        {
            foreach (var num in nums)
            {
                WriteLine(num);
            }

        }


        // O(n^2)
        // Explanation: Runs in n squared or n x n time. 
        // Example

        public void BigOn2(int[] nums)
        {
            foreach (var num in nums)
            {

                foreach (var num2 in nums) { }

                WriteLine("This is Big O(n^2)");

            }

        }


        // O(n^3)
        // Explanation: Runs in n cubed or n x n x n time. 
        // Example

        public void BigOn3(int[] nums)
        {
            foreach (var num in nums)
            {

                foreach (var num2 in nums)
                {

                    foreach (var num3 in nums)
                    {
                        WriteLine("This is Big O(n^2)");
                    }

                    
                }

            }
        }





















    }
}
