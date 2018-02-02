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
        public bool Paid { set; get; }
        public double CancellationFee { get; set; }
        public List<Rider> RiderList { get; set; }
        public Client C { get; set; }
        public Agent A { get; set; }
        public Receipt R { get; set; }
        public PayOutType PayOutType { get; set; }
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
        public void editPolicy()
        {

        }
        public void sendAlert()
        {

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
