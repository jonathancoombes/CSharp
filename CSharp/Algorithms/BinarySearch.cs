using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithms
{
    public class BinarySearch
    {


        private int startPos, midPos, endPos;

        public int binarySearch(int[] data, int search) {

            //Step 1 - Initialize Variables

            startPos = 0;
            endPos = data.Length - 1;

            //Step 2 - Search for the value

            while (startPos <= endPos)
            {          
                midPos = (startPos + endPos) / 2;

                if (search < data[midPos])
                 endPos = midPos - 1;

                
                else if (search > data[midPos])
                    startPos = midPos + 1;             

                else 
                    return midPos;

            }

            //Step 3 - Return Result
            return -1;
        
        }
                     


    }
}
