using System;
using System.Collections;
using System.Configuration;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.Fundamentals
{
    public class Lambdas
    {

        //Classic method syntax

        int MaxNumCalc(int valA, int valB)
        {

            return valA > valB ? valA : valB;

        }
        // Using built-in delegates with Lambdas of:

        // 1.Func<> - if a return value is required

        Func<int, int, int> MaxCalc = (num1, num2) => num1 > num2 ? num1 : num2;

        // 2.Action<> - if a void return is fine 
        Action<int, int> SetMax = (num3, num4) => num3 += num4;

        // 3.Lambda Syntax Note:

        // () => expression      = Used for a lambda with no parameters
        //  n => expression      = Used for a single parameter
        // (x,y.z) => expression = Used when there are multiple parameters


        public Lambdas()
        {
            // Classic Function Call:
            MaxNumCalc(20, 30);

            // Func / Lambda Call:
            MaxCalc(20, 30);

        }


    }
}
