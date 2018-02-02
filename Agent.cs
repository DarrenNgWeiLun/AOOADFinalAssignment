using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Agent:User
    {
        private int noOfPoliciesSold;
        private double totalComission;
        private List<Policy> policyList;
        public void addNewPolicy(Policy p)
        {
            policyList.Add(p);
        }
        public void registerCustomer()
        {

        }
    }
}
