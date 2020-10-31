using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp

{
    public static class  ControlFlow
    {

        public static void theWhile() {

          //while
            
            while (true) {

                Console.WriteLine("this is happenning right now!");

                break;
            
            }
        
        }
        private static List<string> Names = new List<string>();

        // Foreach Loop
        public static void theLoop() {

            Names.Add("John");
            Names.Add("Gladly");
            Names.Add("Tony");

            foreach (var name in Names) {
                Console.WriteLine($"The name is: " + name.Trim());
            };
            Console.ReadLine();

        }

        //ForLoop

        public static void myForLoop() {

            int total = 0;

            for (int i = 0; i <21; i++)
            {
                var result = i % 3;
                if (result == 0) {
                    total += i;
                }
            }

            Console.WriteLine($"The sum of the total integers that are divideable by 3 is: " + total);
            Console.ReadLine();
        
        }

            // Switch


    }
}
