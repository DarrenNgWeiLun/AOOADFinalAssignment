using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Client:User
    {

        public string Address { get; set; }
        public int AccNo { get; set; }
        public List<Policy> PolicyList { get; set; }

        public Client()
        {
            PolicyList = new List<Policy>();
        }
         public void viewPolicy()
        {
            Console.WriteLine("{0,10}{1,20}{2,30}{3,30}", "Index", "Policy No.", "Expiry Date", "Payment Status");
            for(int i = 0; i<PolicyList.Count;i++)
            {
                string asd;
                if (PolicyList[i].Paid)
                    asd = "Not yet Due";
                else
                    asd = "Payment Due";
                Console.WriteLine("{0,10}{1,20}{2,30}{3,30}", (i+1) , PolicyList[i].PolicyNum, PolicyList[i].ExpiryDate, asd);

            }
        }
    }
}
