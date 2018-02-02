using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Travel:Policy
    {
        public Travel()
        {
            PayOutType = new NormalPayOut();
        }
    }
}
