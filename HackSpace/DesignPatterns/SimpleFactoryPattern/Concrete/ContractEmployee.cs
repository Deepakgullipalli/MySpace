using DesignPatterns.SimpleFactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactoryPattern.Concrete
{
    public class ContractEmployee : IEmployeeManager
    {
        public string FetchBonus()
        {
            return "1";
        }

        public string FetchPay()
        {
            return "2";
        }
    }
}
