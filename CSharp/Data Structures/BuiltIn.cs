using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Data_Structures
{
    public static class BuiltIn
    {

        public static int[] myNewArray = new int[] { 5, 10, 15, 20 };

        //Array
        public static void myArray() {

            var result = myNewArray.GetUpperBound(0);
            Console.WriteLine($"The index of the last element is: {result}");
            Console.ReadLine();


        }


        //List

        public static void myList() {

            var names = new List<string>();

            names.Add("John");
            names.Add("Wilson");

            foreach (var name in names) {
                Console.WriteLine($"The person is: {name}");
            }

            Console.WriteLine($"The number of people is : {names.Count}");

            Console.WriteLine($"John can be found at position: {names.BinarySearch("John")}");

            //The following will remove an element aty the specified index

            names.RemoveAt(0);

            // Now checking the result of the remaining elements in the list

            //Now lets add another person to the list

            names.Insert(1, "Lee");

            foreach (var name in names) {
                Console.WriteLine($"The following person is still left: {name}");
            }

            names.Sort();
            Console.ReadLine();

        }

        //LinkedList (based arround array)

        public static void myLinkedList() {

            var linkedNames = new LinkedList<string>();
            linkedNames.AddFirst("Jonathan");
            var theNode = linkedNames.First;
            linkedNames.AddBefore(theNode, "Wilson");

            foreach (var name in linkedNames) {
                Console.WriteLine($"{name}");
            }

            Console.ReadLine();
        }


        //Binary Tree

        //HashTable

       




    }
}
