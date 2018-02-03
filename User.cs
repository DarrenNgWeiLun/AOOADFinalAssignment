using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class User
    {

        public int UserID { get; set; }
        public string Name { get; set; }
        public void viewPolicy()
        {
            if (this is Agent) // check if the user is an Agent
            {
                Agent sampleAgent = (Agent)this; // downcast the user to an agent instance
                List<Policy> policiesOwned = sampleAgent.PolicyList;
                for (int i = 0; i < sampleAgent.PolicyList.Count(); i++)
                {
                    console.WriteLine("{0: 10} {1:10} {2:10}",
                }

            }
        }
    }
}
