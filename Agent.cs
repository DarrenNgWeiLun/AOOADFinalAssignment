using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Agent:User
    {
        private int noOfPoliciesSold; // number of policies sold
        private double totalComission; // the total Comission earned by the agent
        public List<Policy> PolicyList { get; set; } // the list of policies that the agent owns.

        public Agent()
        {
            PolicyList = new List<Policy>();
        }
        public void createNewPolicy()
        {
            {
                Policy p = new Policy();
                Rider r = new Rider();
                Console.WriteLine("Please enter customer Account Number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter terms and condition: ");
                string tac = Console.ReadLine();


                Console.WriteLine("Please enter Premium Cost $: ");
                double premiumCost = Convert.ToDouble(Console.ReadLine());
                r.PremiumCost = premiumCost;

                Console.WriteLine("Please enter Pay out Amount $: ");
                double payOutAmount = Convert.ToDouble(Console.ReadLine());
                r.PayOutAmount = payOutAmount;

                Console.WriteLine("Is premium one time payment?(y/n): ");
                char premiumType = Convert.ToChar(Console.ReadLine());
                if (premiumType == 'y')
                    r.PremiumType = "One Time Payment";
                else
                    r.PremiumType = "Periodic Payment";

                Console.WriteLine("How many years does policy Last?: ");
                int years = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter type of Policy(Car/Medical/Travel): ");
                string policyType = Console.ReadLine().ToUpper();

                if (policyType == "CAR")
                {
                    p = new Car();
                    p.TermsAndConditions = tac;
                    p.ExpiryDate = DateTime.Today.AddYears(years);
                    p.RiderList.Add(r);
                    foreach (Client c in OverallClientList.ClientList)
                    {
                        if (c.AccNo == accNo)
                        {
                            p.C = c;
                        }

                    }

                }
                else if (policyType == "MEDICAL")
                {
                    p = new Medical();
                    p.TermsAndConditions = tac;
                    p.ExpiryDate = DateTime.Today.AddYears(years);
                    p.RiderList.Add(r);
                    foreach (Client c in OverallClientList.ClientList)
                    {
                        if (c.AccNo == accNo)
                        {
                            p.C = c;
                        }

                    }
                }
                else if (policyType == "TRAVEL")
                {
                    p = new Travel();
                    p.TermsAndConditions = tac;
                    p.ExpiryDate = DateTime.Today.AddYears(years);
                    p.RiderList.Add(r);
                    foreach (Client c in OverallClientList.ClientList)
                    {
                        if (c.AccNo == accNo)
                        {
                            p.C = c;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Not valid policy Type");
                }

                Console.WriteLine("Is rider needed?(y/n)");
                char rider = Convert.ToChar(Console.ReadLine().ToUpper());
                while (rider == 'Y')
                {
                    Console.WriteLine("Please enter premium for rider: ");
                    premiumCost = Convert.ToDouble(Console.ReadLine());
                    r.PremiumCost = premiumCost;

                    Console.WriteLine("Is premium one time payment?(y/n): ");
                    premiumType = Convert.ToChar(Console.ReadLine());
                    if (premiumType == 'y')
                        r.PremiumType = "One Time Payment";
                    else
                        r.PremiumType = "Periodic Payment";

                    Console.WriteLine("Please enter Pay out Amount $: ");
                    payOutAmount = Convert.ToDouble(Console.ReadLine());
                    r.PayOutAmount = payOutAmount;

                    p.RiderList.Add(r);
                    Console.WriteLine("Is another rider needed?(y/n)");
                    rider = Convert.ToChar(Console.ReadLine().ToUpper());

                }
                Console.WriteLine("Name of Client: " + p.C.Name);
                Console.WriteLine("Terms and Condition: " + p.TermsAndConditions);
                Console.WriteLine("Expiry Date: " + p.ExpiryDate);
                Console.WriteLine("Type of Policy: " + p, GetType());
                Console.WriteLine("{0,10}{1,20}{2,20}{3,30}", "Rider Index", "Rider Premium", "Rider Payout", "Premium Type");
                for (int i = 0; i < p.RiderList.Count; i++)
                {
                    Console.WriteLine("{0,10}{1,20}{2,20}{3,30}", (i + 1), p.RiderList[i].PremiumCost, p.RiderList[i].PayOutAmount, p.RiderList[i].PremiumType);
                }

                PolicyList.Add(p);
                Console.WriteLine("Policy added.");
                
            }
            }
        
        public void registerCustomer()
        {

        }
    }
}
