using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithms
{
    public class BinarySearch2
    {
        //Binary Search only works on a sorted collection of data. 

        // 1. Define variables: startPos, midPos, endPos. 
        // 2. Define the method which will take in the dataStructure and search term as params.
        // 3. Inside the method, define a while statement that runs whilst the start position is 
        //    smaller than or equals the end position.
        // 3. Inside the while loop should be a if statement which checks whether
        //    the search term is smaller than or equal to the value of the element at the midPosition
        //    of the array collection, if TRUE assign the endPos to the current midPos -1. If FALSE
        //    assignment the startPos the new value of the current midPos +1.
        // 4. After the while loop, return the value of the midPos.
        // 5. Else, return -1 if not found.


        int startPos, midPos, endPos;

        public int binarySearch(int[] myData, int findVal)
        {

            startPos = 0;
            endPos = myData.Length;

            while (startPos < endPos)
            {

                midPos = (startPos + endPos) / 2;

                return findVal < myData[midPos] ? endPos = midPos - 1 : startPos = midPos + 1;

            }

            return -1;

        }








    }
}
