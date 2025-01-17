﻿using System.IO;
using System.Reflection;

namespace Classes
{
    public class Program
    {
        //Parts of a class:
        //Access Modifier Keywords - OPTIONAL
        //class Keyword - REQUIRED
        //Name - REQUIRED
        //Scope or “curly brackets” - REQUIRED
        //    Fields - OPTIONAL
        //    Properties - OPTIONAL
        //    Methods - OPTIONAL

        //Create a class named Car - make sure it is public
        //In the Car class:
        //Create a Make property of type string that is public
        //Create a Model property of type string that is public
        //Create a Year property of type int that is public
        //In the Main method:
        //Create a new instance of the Car class
        //Set values in the properties for the object
        //Print the values of each property to the Console

        static void Main(string[] args)
        {
            var mycar = new Cars();
            mycar.Make = "Toyota";
            mycar.Model = "Corolla";
            mycar.Year = 1999;
            Console.WriteLine("Here are the properties for my new car class");
            
            //Console.WriteLine($"The make of mycar is {mycar.Make}");
            //Console.WriteLine($"The model of mycar is {mycar.Model}");
            //Console.WriteLine($"The Year of mycar is {mycar.Year}");
            Console.WriteLine($"The Make, Model and Year of My car is: {mycar.Make} {mycar.Model} {mycar.Year}");

            }
    }

 
}
