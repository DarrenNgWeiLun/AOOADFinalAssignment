using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Medical:Policy
    {
        public Medical()
        {
            PayOutType = new PartialPayOut();
        }
    }
}
