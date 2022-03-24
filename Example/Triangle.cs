using System;

namespace TdExample.Example
{
    class Triangle
    {
        //member variable
        private double width;
        private double height;

        //parametelized constructor
        public Triangle(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public Triangle()
        {

        }

        //method
        public void AcceptDetails()
        {
            //width = 4.6;
            //height = 6.7;
        }

        public double CalculateArea()
        {
            return 0.5 * width * height;
        }

        public void DisplayResult()
        {
            Console.WriteLine("Width {0}", width);
            Console.WriteLine("Area {0}", CalculateArea());
           
        }


    }
}
