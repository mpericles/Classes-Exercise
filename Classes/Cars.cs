using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cars
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

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
