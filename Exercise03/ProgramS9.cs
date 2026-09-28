using System;
using System.Collections.ObjectModel;

//Exercise 4 CH4 section 4.1
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight tl = new();
            Console.WriteLine(tl.colours);
            tl.changeToRed();
            Console.WriteLine(tl.colours);
            tl.changeToYellow();
            Console.WriteLine(tl.colours);

        }
    }
    public class TrafficLight
    {
        public Colors colours {get; set;} //property of the class

        /*public TrafficLight(Colors colors) //constructor
        {
            colours = colors;
        }*/

        public void changeToRed() //void function tha assign the color red to "colours"
        {
            colours = Colors.Red;
        }

         public void changeToYellow() //void function tha assign the color yellow to "colours"
        {
            colours = Colors.Yellow;
        }
        
        public enum Colors //enum that list all the colors needed for the program
        {
            Red,
            Yellow,
            Green,
        }
    }
}

