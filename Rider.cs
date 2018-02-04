using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Rider
    {
        //private attributes
        private int riderID;
        private double premiumCost;
        private string premiumType;
        private double payOutAmount;
        private double interestForLatePayment;
        private Policy policy;

        //getter and setters
        public int RiderID { get; set; }
        public double PremiumCost { get; set; }
        public string PremiumType { get; set; }
        public double PayOutAmount { get; set; }
        public double InterestForLatePayment { get; set; }
        public Policy Policy { get; set; }

        //default constructor
        public Rider() { }
        // Constructor
        public Rider(int riderID,double premiumCost,string premiumType, double payOutAmount,double interestForLatePayment)
        {
            this.RiderID = riderID;
            this.PremiumCost = premiumCost;
            this.PremiumType = premiumType;
            this.PayOutAmount = payOutAmount;
            this.InterestForLatePayment = interestForLatePayment;
        }
    }
}
