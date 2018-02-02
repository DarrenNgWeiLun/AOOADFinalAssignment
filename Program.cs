using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please login as(client/agent) : ");
            if(Console.ReadLine().ToUpper() == "AGENT")
            {
                Console.WriteLine("Logged in as Agent");
                Agent sampleAgent = new Agent();
                Console.WriteLine("=====================Agent Functions================");
                Console.WriteLine("1. Create New Policy (Darren)");
                Console.WriteLine("2. Edit Policy (Haiqel)");
                Console.WriteLine("3. Send Email Alerts for policies with premium due (LiJun)");


                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Policy p = new Policy();
                    Rider r = new Rider();
                    Console.WriteLine("Please enter customer Account Number: ");
                    int accNo = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Please enter terms and condition: ");
                    string tac = Console.ReadLine();
                    p.TermsAndConditions = tac;


                    Console.WriteLine("Please enter Premium Cost $: ");
                    double premiumCost = Convert.ToDouble(Console.ReadLine());
                    r.PremiumCost = premiumCost;

                    Console.WriteLine("Please enter Pay out Amount $: ");
                    double payOutAmount = Convert.ToDouble(Console.ReadLine());
                    r.PayOutAmount = payOutAmount;

                    Console.WriteLine("Is premium one time payment?(y/n): ");
                    char premiumType =Convert.ToChar(Console.ReadLine());
                    if (premiumType == 'y')
                        r.PremiumType = "One Time Payment";
                    else
                        r.PremiumType = "Periodic Payment";

                    Console.WriteLine("How many years does policy Last?: ");
                    int years = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter type of Policy(Car/Medical/Travel: ");
                    string policyType = Console.ReadLine().ToUpper();
                    Console.WriteLine("Is rider needed?");
                    char rider = Convert.ToChar(Console.ReadLine().ToUpper());
                    if(rider == 'Y')
                    {
                        Console.WriteLine("Please enter premium for rider: ");
                        premiumCost = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Is premium one time payment?(y/n): ");
                        premiumType = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Please enter Pay out Amount $: ");
                        payOutAmount = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        sampleAgent.addNewPolicy(p);
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
