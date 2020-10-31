using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Data_Structures_Manual
{
    public class Array
    {
        private string[] Data { get; set; }
        private string[] DataResize { get; set; }
        private int _pos;

        public Array(int len)
        {
            _pos = 0;
            Data = new string[len];
        }

 
        public void insert(string item)
        {
            if (_pos < Data.Length)
            {
                Data[_pos++] = item;
                
            }
            //If the Array is full
            else
            { 
                //Create a new array with say, double the original space;

                DataResize = new string[_pos * 2];

                //Copy the existing items into the new array
                for (int i = 0; i < _pos; i++)
                {
                    DataResize[i] = Data[i];
                }
                
                //Add the latest item for insertion
                DataResize[_pos++] = item;

                //Set the old array equal to the new one
                Data = DataResize;

            }

        }

        public void remove(int remAt)
        {
            //Validate index

            if (Data[remAt] != null)
            {
                //Create new array

                DataResize = new string[_pos];

                //1st Approach - copy all items except selected into new array
                for (int i = 0; i < _pos; i++)
                {
                    if (Data[i] != Data[remAt])
                    {
                        DataResize[i] = Data[i];
                    }
                }
                
                // Set Data equal to new array

                Data = DataResize;

            }

            

        }

        public void print()
        {
            for (int i = 0; i < _pos; i++)
            {
                Console.WriteLine(Data[i]);
            }
            Console.ReadLine();
        }


    }
}
