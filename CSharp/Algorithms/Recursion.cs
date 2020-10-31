using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ConsoleApp.Algorithms
{
   public static class Recursion { 
        public static void CountDownEvent(int start)
        {

            while (start >= 0)
            {
                WriteLine($"The number is currently: {start}");
                start--;
                CountDownEvent(start);
            }
            ReadLine();
        }


    }
}
