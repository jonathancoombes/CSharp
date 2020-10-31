using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithms
{
    public static class Fibonacci
    {

        public static List<int> fibSequenceResult = new List<int>();

        public static void FibonacciSequence(int start, int end)
        {

            int firstNum = start;
            int secondNum = firstNum + 1;

            int fibSubTotal;
            var fibNumSequence = new List<int>();

            while (secondNum < end)
            {

                fibSubTotal = firstNum + secondNum;

                fibNumSequence.Add(fibSubTotal);
                secondNum = fibSubTotal + secondNum;
                firstNum = fibSubTotal;
                Console.WriteLine(firstNum);
                Console.WriteLine(secondNum);

            }


        }
    }
}
