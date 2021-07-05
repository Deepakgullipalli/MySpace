using DesignPatterns.SimpleFactoryPattern.Concrete;
using DesignPatterns.SimpleFactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactoryPattern.Factory
{
    public class EmployeeFactory
    {
        public IEmployeeManager FetchEmployeeManager(Employee employee)
        {
            if(employee.Id == 1)
            {
                return new PermanentEmployee();
            }
            return new ContractEmployee();
        }
    }
}
