using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class terminateState:Pstate
    {
        private Policy myPolicy;
        public terminateState(Policy policy)
        {
            myPolicy = policy;
        }
        public void payPremium()
        {
            Console.WriteLine("Policy already terminated, could not pay premium");
        }
        public void agentTerminate()
        {
            Console.WriteLine("Policy already terminated.");
        }
        public void custTerminate()
        {
            Console.WriteLine("Policy already terminated.");
        }
        public void setToLapsed()
        {
            Console.WriteLine("Could not set to lapsed in terminated state.");
        }
        public void payOut()
        {
            Console.WriteLine("Pay out could not be executed, policy already terminated");
        }
    }
}
