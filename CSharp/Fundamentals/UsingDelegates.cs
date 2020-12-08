using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp.Fundamentals
{
   public class UsingDelegates
   {
       // Console App Test Code
       // -Start

       //UsingDelegates newIns = new UsingDelegates();
       //UsingDelegates.CalculateDel Del = newIns.CalculateAdd;
       //Console.WriteLine(Del("one", "two"));

       // -End

       public delegate string CalculateDel(string aString, string bString);
       

        public string CalculateAdd(string a, string b)
        {
            return a += b;
        }

        public string CalculateResults(string x, string z)
        {
            return $"The result is: {x += z}";
        }

   }
}
