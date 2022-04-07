using System;
using TDExample2.ABSTRACTION;
using TDExample2.ENCAPSULATION;

namespace TDExample2.ThisKeywordOnSttaic
{

    class Program
    {
        public void Sum(int y)
        {
            Console.WriteLine("the sum is : " + y);
        }



        //Creating an instant of all classes here
        static void Main(string[] args)
        {
            //Program p = new();
            //p.Sum(10);
            //p.Sub();

            ////===================================

            //Rectangle rectangle = new Rectangle();
            //rectangle.SetWidth(0);
            //Console.WriteLine(rectangle.GetWidth());

            //===================================

            //var customer = new Customer();
            //customer.FirstName = "George";
            //Console.WriteLine(customer.FirstName);
            //customer.LastName = "Ofure";
            //Console.WriteLine(customer.LastName);
            //Console.WriteLine("The full name is : {0} {1}", customer.LastName , customer.FirstName);


            //======================================

            //var student = new Student("EQ12345");
            //student.GetMatricNumber();

            var carloan = new CarLoan("Kunle Olajide",2400, "TD Africa");
            carloan.GetInterestRate();
            carloan.DisplayEmployeeData();
            carloan.GetEmployeeData();
            carloan.CalculateInterestRate(4500000);

            Console.WriteLine("===============\n");

            var houseloan = new HouseLoan("Ade Kenny", 4890, "Kenny International");
            houseloan.DisplayEmployeeData();
            houseloan.GetEmployeeData();
            houseloan.GetInterestRate();
            houseloan.CalculateInterestRate(7600000);


        }
    }

    
    
    static class Test
    {

        //I could create a static class and because i want to extend the behaviour on the instatnce
        //of Class Program without altering the existing code of the source class(program).

        //Technically the answer is NO But there is a situation where we can use this keyword in static method, that is EXTENSION METHOD. 
        //In an interview question, just say NO
        public static void Sub(this Program program)
        {
            Console.WriteLine("this is the sub method!");
        }
    }

    // We can use this keyword in static method.
}
