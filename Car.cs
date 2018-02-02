using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Car:Policy
    {
        public Car()
        {


            PayOutType = new NormalPayOut();
        }
    }
}
