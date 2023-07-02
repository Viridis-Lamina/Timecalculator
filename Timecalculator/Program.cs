using System;
using System.Reflection.Metadata;

namespace Timecalculator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First thing i do is establish the vairables. One for hours. One for Minutes and one for converting a string to an interger
            int Hours;
            int remainder;
            int Conversion;
           
            // Next I get the user to input their value in minutes
            Console.WriteLine("Please input the time taken in minutes");
            String input = Console.ReadLine();

            // I then convert the string to an interger giving the conversion vairable its value.
            // I used an interger because i want the program to round to the closet whole number so i can establish a remainder.
            Conversion = Convert.ToInt32(input);
          
            // I get the system to calculate outputs for the vairables 

            Hours= Conversion / 60;
            remainder = Conversion % 60;

            Console.WriteLine(" Total time taken is {0} hours and {1} Minutes",Hours,remainder);





        }
    }
}