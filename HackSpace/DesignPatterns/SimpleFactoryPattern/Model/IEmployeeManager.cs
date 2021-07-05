using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactoryPattern.Model
{
    public interface IEmployeeManager
    {
        string FetchBonus();
        string FetchPay();
    }
}
