using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    interface Pstate
    {
        void payPremium();
        void setToLapsed();
        void custTerminate();
        void agentTerminate();
        void payOut();
    }
}
