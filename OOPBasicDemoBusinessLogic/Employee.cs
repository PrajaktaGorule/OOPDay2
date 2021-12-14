using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicDemoBusinessLogic
{
    public class Employee
    {
        //Attriubutes : Member Variables : Properties

        int PaySlipNumber;
        string EmployeeName;
        string EmployeeContactNumber;
        DateTime EmployeeDateOfJoining;
        
        //Special Method with same name of class
        //You do not need a return type

        //Custom Default Constructor : NOT PROVIDED : THEN .NET Will automatically provision one
        public Employee()
        { // Initialisation before you start 
            Console.WriteLine("This is a constructor");
        }

        //Parameterized Constructor
        public Employee(int psnumber,string name,string phonenumber,DateTime dateofjoining)
        {
            if (psnumber > 0)
            {
                PaySlipNumber = psnumber;
                EmployeeName = name;
                EmployeeContactNumber = phonenumber;
                EmployeeDateOfJoining = dateofjoining;
            }
           
        }

        //Get Method  to get the ps number of the new joinee
        public int GetPSNumber()
        {
            return PaySlipNumber;
        }

        //GetMethod

        public string GetName()
        {
            return EmployeeName;
        }
    }
}
