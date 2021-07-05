using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using DesignPatterns.SimpleFactoryPattern.Factory;
using DesignPatterns.SimpleFactoryPattern.Model;

namespace DesignPatterns.SimpleFactoryPattern.Client
{
    public class SimpleFactoryClient
    {
        static void Main(string[] args)
        {
            SimpleFactoryClientMain();
        }
        public static void SimpleFactoryClientMain()
        {
            Employee employee = new Employee();
            //employee.Id = 1;
            EmployeeFactory employeeFactory = new EmployeeFactory();
            IEmployeeManager employeeManager = employeeFactory.FetchEmployeeManager(employee);
            Console.WriteLine(employeeManager.FetchBonus());
            Console.WriteLine(employeeManager.FetchPay());
        }
    }
}
