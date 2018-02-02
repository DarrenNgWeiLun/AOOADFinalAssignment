using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Policy
    {

        public int PolicyNum { get; set; }
        public string TermsAndConditions { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Comission { get; set; }
        public double TotalPremiumCost { get; set; }
        public bool Paid { get; set; }
        public double CancellationFee { get; set; }
        public List<Rider> RiderList { get; set; }
        public Client C { get; set; }
        public Agent A { get; set; }
        public Receipt R { get; set; }

        //state
        //payouttype

        public void performPayOut()
        {
            //payouttype.payout();
        }
        public void editPolicy()
        {

        }
        public void sendAlert()
        {

        }
        public void payPremium()
        {

        }
        public bool payPenaltyFee()
        {
            return true;
        }
        public void custTerminate()
        {

        }
        public void agentTerminate()
        {

        }



    }
}
