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
            if (this is Agent || this is Administrator) // check if the user is an Agent
            {
                Agent sampleAgent = (Agent)this; // downcast the user to an agent instance
                List<Policy> policiesOwned = sampleAgent.PolicyList;
                if (policiesOwned.Count() == 0)
                {
                    Console.WriteLine("The agent does not have any policies at the moment!");
                }
                else
                {
                    // prints the data's column headers
                    Console.WriteLine("{0,10} {1,10} {2,10} {3,10}", "Policy Number", "T&Cs", "Expiry Date", "Total Premium Cost"); 
                   
                    for (int i = 0; i < sampleAgent.PolicyList.Count(); i++)
                    {
                        Console.WriteLine("{0,10} {1,10} {2,10} {3,10}", policiesOwned[i].PolicyNum,
                            policiesOwned[i].TermsAndConditions, policiesOwned[i].ExpiryDate,
                            policiesOwned[i].TotalPremiumCost);
                    }
                }
            }
            else if (this is Client)
            {

            }
        }
    }
}
