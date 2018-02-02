using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class ActiveState:Pstate
    {
        private Policy myPolicy;
        public ActiveState(Policy policy)
        {
            myPolicy = policy;
        }
        public void payPremium()
        {
            Console.WriteLine("Premium Paid");
        }
        public void setToLapsed()
        {
            if (myPolicy.Paid == false)
            {
                Console.WriteLine("Policy Set to lapsed.");
                myPolicy.setState(myPolicy.lapsedState);
            }
            else
                Console.WriteLine("Customer paid premium, cannot set to lapsed.");

        }
        public void payOut()
        {
            Console.WriteLine("Policy has been covered or expired(maturity payout)");
            myPolicy.setState(myPolicy.terminateState);
        }
        public void custTerminate()
        {
            myPolicy.payPenaltyFee();
            Console.WriteLine("Policy has been terminated by customer");
            myPolicy.setState(myPolicy.terminateState);
        }
        public void agentTerminate()
        {
            Console.WriteLine("Policy has been terminated by agent");
            myPolicy.setState(myPolicy.terminateState);
        }
    }
}
