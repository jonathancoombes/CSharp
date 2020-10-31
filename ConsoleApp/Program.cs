using System;
using CSharp;
using ConsoleApp.Data_Structures_Manual;
using static System.Console;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net.NetworkInformation;
using ConsoleApp;
using CSharp.Advanced;

namespace ConsoleApp
{
    
    public class Program
    {

        public static void Main(string[] args)
        {
            var myList = new LinkedList2(5);
            
            myList.Prepend(10);
            myList.Prepend(20);
            myList.Prepend(30);

            myList.Prepend(40);
            myList.Prepend(50);
            myList.Prepend(60);
            myList.Prepend(70);

            Console.WriteLine("Removing Head");
            myList.RemoveHead();
            myList.PrintContents();

            //Console.WriteLine("Removing Tail");
            //MyList.RemoveTail();
            //MyList.PrintContents();

            ReadLine();
        }

    }


    

}