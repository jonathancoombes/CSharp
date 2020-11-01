using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Fundamentals
{
    public class GenericsComparison
    {
        //The use of IComparible to compare two generic objects using .CompareTo

        // The following constraints can be used as follows:

        // where T : IComparable
        // where T : Product
        // where T : struct
        // where T : class
        // where T : new()


        public T MaxNumber<T>(T numA, T numB) where T : IComparable
        {

            return numA.CompareTo(numB) > 0 ? numB : numA;
        }

    }
}
