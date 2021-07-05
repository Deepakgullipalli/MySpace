using Puzzles.Tasks.Microsoft.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft
{
    public abstract class Abstraction : IAbstraction
    {
        public Abstraction()
        {

        }

        static Abstraction()
        {

        }
        
        public void getMyName()
        {
            throw new NotImplementedException();
        }
    }
}
