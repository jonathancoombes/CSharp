using System;
using System.ComponentModel.DataAnnotations;
using ConsoleApp.Data_Structures_Manual;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using ConsoleApp;
using ConsoleApp.Fundamentals;


namespace ConsoleApp
{

    public class Program
    {

        public static void Main(string[] args)
        {
            //Sorted Array
            var inputArray = new int[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            var searchVal = 90;

            var newBo = new BigO();

            // BigO1 Test - Uncomment line below to run
            // newBo.BigO1(inputArray);

            // BigOLogN Test - Uncomment line below to run
               newBo.BigOLogN(searchVal, inputArray);

            // BigOn Test - Uncomment line below to run
               newBo.BigOn(inputArray);



            Console.ReadLine();
        }

    }
}