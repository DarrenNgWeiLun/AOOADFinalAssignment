﻿using System;
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
        public Policy p { get; set; }

        // Constructor
        public Rider(int riderID,double premiumCost,string premiumType, double payOutAmount,double interestForLatePayment)
        {
            this.riderID = riderID;
            this.premiumCost = premiumCost;
            this.premiumType = premiumType;
            this.payOutAmount = payOutAmount;
            this.interestForLatePayment = interestForLatePayment;
        }
    }
}
