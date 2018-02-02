using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class lapsedState:Pstate
    {
        private Policy myPolicy;
        public lapsedState(Policy policy)
        {
            myPolicy = policy;
        }
        public void payPremium()
        {
            Console.WriteLine("Premium paid including interest if any.");
            Console.WriteLine("Policy Reactivated");
            myPolicy.setState(myPolicy.activeState);
        }
        public void custTerminate()
        {
            myPolicy.payPenaltyFee();
            Console.WriteLine("Premium paid including interest if any.");
            Console.WriteLine("Policy has been terminated by customer");
            myPolicy.setState(myPolicy.terminateState);
        }
        public void setToLapsed()
        {
            Console.WriteLine("Already in lapsed State");
        }
        public void agentTerminate()
        {
            Console.WriteLine("Policy has been terminated by agent");
            myPolicy.setState(myPolicy.terminateState);
        }
        public void payOut()
        {
            Console.WriteLine("Lapsed policy cannot be paid out.");
        }
    }
}

