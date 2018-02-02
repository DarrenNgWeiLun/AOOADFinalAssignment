using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Rider
    {
        private int riderID;
        private double premiumCost;
        private string premiumType;
        private double payOutAmount;
        private double interestForLatePayment;
        private Policy policy;

        public int RiderID { get; set; }
        public double PremiumCost { get; set; }
        public string PremiumType { get; set; }
        public double PayOutAmount { get; set; }
        public double InterestForLatePayment { get; set; }
        public Policy p { get; set; }

        
    }
}
