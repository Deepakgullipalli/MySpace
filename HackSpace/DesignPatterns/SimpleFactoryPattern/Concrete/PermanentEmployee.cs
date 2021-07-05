using DesignPatterns.SimpleFactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactoryPattern.Concrete
{
    public class PermanentEmployee : IEmployeeManager
    {
        public string FetchBonus()
        {
            return "3";
        }

        public string FetchPay()
        {
            return "4";
        }
    }
}
