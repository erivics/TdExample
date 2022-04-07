using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDExample2.ABSTRACTION
{   
    //ABSTRACT CLASS
    public abstract class AbstractInterest
    {
        //Protected for Derived class to have access to since is only subclass that can
        //implemet any abstract class inherited only.
        protected decimal rate;
        protected int employeeId;
        protected string employeeName;

        
        //Abstract Method
        public abstract void GetInterestRate(); 
        public abstract string GetEmployeeData();


        //Virtual keyword to be able to override it. else Compiler see
        //as you have hidden intention for the method
        public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Id is : {0} ", this.employeeId);
            Console.WriteLine("Employee name is : {0} ", this.employeeName);
        }

        //Non-Static Method in Abstract class
        public void CalculateInterestRate(decimal amount) 
        {
            Console.Write("Charged intrest amount for this Loan of : " + amount + " naira is :N");
            Console.WriteLine(rate * amount);
        }
    }


    public class CarLoan : AbstractInterest   
    {
        string companyName;

        public CarLoan(string employeename, int employeeid, string companyname)
        {
            companyName = companyname;
            employeeId = employeeid;
            employeeName = employeename;

        }
        //NOTE: CarLoan class implement only the abstract class by overriding it
        //Try remove the override and the virtual keyword to see the error
        public override void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Id is : {0} ", this.employeeId);
            Console.WriteLine("Employee name is : {0} ", this.employeeName);
            Console.WriteLine("Company name is : {0} ", this.companyName);
        }

        public override void GetInterestRate()
        {
            rate = 0.40m;
        }

        public override string GetEmployeeData()
        {
            return companyName;
        }
    }



    public class HouseLoan : AbstractInterest  
    {
        string companyName;

        public HouseLoan(string employeename, int employeeid, string companyname)
        {
            companyName = companyname;
            employeeId = employeeid;
            employeeName = employeename;

        }
        //NOTE: CarLoan class implement only the abstract class by overriding it
        //
        public override void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Id is : {0} ", this.employeeId);
            Console.WriteLine("Employee name is : {0} ", this.employeeName);
            Console.WriteLine("Company name is : {0} ", this.companyName);
        }

        public override void GetInterestRate()
        {
            rate = 0.50m;
        }

        public override string GetEmployeeData()
        {
            return companyName;
        }
    }
}
