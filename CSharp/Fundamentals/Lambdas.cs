using System;

namespace ConsoleApp.Fundamentals
{
    public class Lambdas
    {

        //Classic method syntax

        int MaxNumCalc(int valA, int valB) {

            return 0;

        }
        // Using built-in delegates with Lambdas of:
    
        // 1.Func<> - if a return value is required

        Func<int, int, int> MaxCalc = (num1, num2) => num1 > num2 ? num1 : num2;

        // 2.Action<> - if a void return is fine 
        Action<int, int> SetMax = (num3, num4) => num3 += num4;
        
        public Lambdas()
        {
            // Classic Function Call:
            MaxNumCalc(20, 30);
            
            // Func / Lambda Call:
            MaxCalc(20,30);
            

        }


        
        
    } 
}
