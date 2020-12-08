using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ConsoleApp.Fundamentals
{

    // Task: Search, find and resolve problems

    // Problem #1: No null or empty check for the input array
    // Solution #1 Applied: Created a Helper Function using generics to Check Array for a null or empty state

    // Problem #2: In BigOLogN, no sorting was applied to the input array as required for the function
    // Solution #2 Applied: Sorted the input array before use

    // Problem #3: In BigOLogN, the function did not return the correct index in case of upper value
    // Solution #3 Applied: Rewrote function to correct midpoint tracking / calculation

    // Problem #4: In function BigOLogN the "ops" variable was not incremented upon operation
    // Solution #4: Incremented counter per operation

    // Problem #5: In both functions BigOn2 and BigOn3 the iterated value was never called during the foreach iteration.
    // Solution #5: Added the necessary variable for display of iteration


    //The following BigO class aims to demonstrate the main Big O runtime examples and concepts to understand

    public class BigO 
    {

         // Solution #1: Helper Function

            public bool ArrayNullorEmpty <T> (T[] array)
            {
                if(array != null && array.Length != 0)
                {
                    return false;
                } 
                return true;
            }


        // O(1)
        // Explanation: Runs in constant time
        // Example
        
        public void BigO1(int[] nums)
        {
            if (!ArrayNullorEmpty(nums))
            {
                WriteLine(nums[0]);
            }
            
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
            int ops = 0;
            
            // Solution #2 Sorting Array

            Array.Sort(setNums);

            // Solution #3 Corrected midpoint tracking / calculation

            int midPoint = 0;
            int minVal = 0;
          
            if (!ArrayNullorEmpty(setNums))
            {
                int maxVal = setNums.Length - 1;

                while (minVal <= maxVal)
                {
                    // Solution #4 Counting operations

                    ops++;

                    midPoint = (minVal + maxVal) / 2;

                    if (num == setNums[midPoint])
                    {
                        break;
                    }
                    if (num < setNums[midPoint])
                    {
                        maxVal = minVal - 1;
                    }
                    else
                    {
                        minVal = midPoint + 1;
                    }
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
            if (!ArrayNullorEmpty(nums))
            {
                foreach (var num in nums)
                {
                    WriteLine(num);
                }
            }

        }

        // O(n^2)
        // Explanation: Runs in n squared or n x n time. 
        // Example

        public void BigOn2(int[] nums)
        {
            if (!ArrayNullorEmpty(nums))
            {
                foreach (var num in nums)
                {
                    // Solution 5: Added call to iteration variable to display result

                    WriteLine(num);

                    foreach (var num2 in nums)
                    {
                        WriteLine(num2);
                    }

                    WriteLine("This is Big O(n^2)");
                }
            }
        }
        
        // O(n^3)
        // Explanation: Runs in n cubed or n x n x n time. 
        // Example

        public void BigOn3(int[] nums)
        {
            if (!ArrayNullorEmpty(nums))
            {
                foreach (var num in nums)
                {
                    WriteLine(num);

                    foreach (var num2 in nums)
                    {
                        WriteLine(num2);

                        foreach (var num3 in nums)
                        {
                            WriteLine(num3);

                            WriteLine("This is Big O(n^2)");
                        }
                    }
                }
            }
        }





















    }
}
