using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class DataTypes
    {
        //Value Types
        static int integerMin = -2147483648;
        static int integerMax = 2147483647;

        static long longVal = 277798100982676;

        static double doubleMin = 80.50d; // Double precision 32 bit
        static float floatNum = 199.45f; // 128 Bit floating point number
        static decimal decNum = 5888.99m; // Single precision 16bit (Monetary Values)
        
        //Reference Types
        static string myString = "MyString"; //.NET TYpe System.String
        static char myChar = 'e';

        //Boolean
        static bool isTrue = true;

        //DateTime
        static DateTime todayDate = DateTime.Now;

        //Struct
        public struct Grade {
        static string Badge = "green";
        static decimal Percentage = 0.75m;
        }

        public enum Colours { 
        
            blue, green, orange, black, white, red
        
        }


    }
}
