using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Policy
    {
        // private attributes
        private int policyNum;
        private string termsAndConditions;
        private DateTime expiryDate;
        private double comission;
        private double totalPremiumCost;
        private bool paid;
        private double cancellationFee;

        //public attributes
        public int PolicyNum { get; set; } // the policy ID
        public string TermsAndConditions { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Comission { get; set; } // the comssion that each Agent will earn upon selling of this policy
        public double TotalPremiumCost { get; set; }
        public bool Paid { set; get; } // check if the policy has been paid or not
        public double CancellationFee { get; set; }
        public List<Rider> RiderList { get; set; } // this is the list of riders that the policy has
        public Client C { get; set; } // The client who owns this policy
        public Agent A { get; set; } // the Agent who has this policy
        public Receipt R { get; set; } // the receipt
        public PayOutType PayOutType { get; set; } // the payout type
        public Pstate State { get; set; }

        public Pstate activeState { get; set; }
        public Pstate lapsedState { get; set; }
        public Pstate terminateState { get; set; }

        public Policy()
        {

            activeState = new ActiveState(this);
            lapsedState = new lapsedState(this);
            terminateState = new terminateState(this);
            State = activeState;
            RiderList = new List<Rider>();
        }

       
        public void setState(Pstate state)
        {
            this.State = state;
        }
        public void performPayOut()
        {
            if (DateTime.Today > ExpiryDate)
                PayOutType = new MaturityPayOut();
            PayOutType.payOut();
            this.State.payOut();
        }

        // Haiqel's Use Case
        public void editPolicy(List<Rider> riderList, List<Rider> globalRiderList, int selectedRiderID)
        {
            riderList.Add(globalRiderList[selectedRiderID - 1]);
        }
        public void sendAlert()
        {
            if (this.State == this.activeState)
            {
                Console.WriteLine("Payment is made and there are no payments due!");
                Console.WriteLine("Bringing you back to the menu.....");
            }
            else if (this.State == this.lapsedState)
            {
                // local attribute
                string choice;
                Console.Write("Do you want alert by email or letter? (email/letter) : ");
                choice = Console.ReadLine();
                if (choice == "email")
                {
                    Console.WriteLine("Client will be informed through email");
                    Console.WriteLine("Bringing you back to the menu......");
                }
                else if (choice == "letter")
                {
                    Console.WriteLine("CLient will be informed through an alert letter");
                    Console.WriteLine("Bringing you back to the menu......");
                }
            }
        }
        public void payPremium()
        {
            Paid = true;
            this.State.payPremium();
        }
        public void payPenaltyFee()
        {
            Console.WriteLine("Penalty fee paid");
        }
        public void custTerminate()
        {
            this.State.custTerminate();
        }
        public void agentTerminate()
        {
            this.State.agentTerminate();
        }
        public void setToLapsed()
        {
            this.State.setToLapsed();
        }



    }
}
