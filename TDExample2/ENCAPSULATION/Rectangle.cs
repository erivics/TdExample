using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDExample2.ENCAPSULATION
{
    
    //using MEthod
    class Rectangle
    {
        //Declaring the member field private to prevent also to be able to validate any data being passed
        private double Width;

        //declaring method to set the value for the member field we declared private
        public double GetWidth()
        {
            return Width;
        }

        //With set method, we could try validate the parameter we want to pass before assignng the value to private field
        public void SetWidth(double width)
        {
            if (width <= 0) Console.WriteLine("Pass value greater than 1");
            else
            {
                this.Width = width;
            }
            
            
        }
    }


    //Using GET SET Accessor
    class Customer
    {
        private string firstName;
        private string lastName;

        public Customer()
        {
            
        }

        //Using get/set accessor to pass value
        public string FirstName
        {

            get
            {
                return firstName;
            }

            set
            {

                if (string.IsNullOrEmpty(value)) Console.WriteLine("Please in put the first name");
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {

                if (string.IsNullOrEmpty(value)) Console.WriteLine("Please in put the last name");
                else
                {
                    this.lastName = value;
                }
            }
        }


    }


    //Pssing via the constructor
    class Student
    {
        private string MatricNumber;

        public Student(string matric)
        {
            this.MatricNumber = matric;
        }

        public void GetMatricNumber()
        {
            Console.WriteLine("My matric Number is : " + MatricNumber);
        }
    }
}
