using OOPBasicDemoBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EMS");
            Console.WriteLine("Enter PS Number");
            int inPSNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string inEmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Contact Number");
            string inEmpCtNumber = Console.ReadLine();            
            DateTime inEmpDoJ = System.DateTime.Now;
            //Constructor

            Employee newEmpJoinee = new Employee(inPSNumber, inEmpName, inEmpCtNumber, inEmpDoJ);
            Console.WriteLine("New Employee Onboarded");
            Console.WriteLine("His/Her PS NUmber is "+ newEmpJoinee.GetPSNumber());
        }
    }
}
