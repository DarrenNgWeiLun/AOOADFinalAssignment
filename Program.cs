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
            string option = Console.ReadLine().ToUpper();
            if (option == "AGENT")
            {

                Console.WriteLine("Logged in as Agent");
                Agent sampleAgent = new Agent();
                Console.WriteLine("=====================Agent Functions================");
                Console.WriteLine("1. View Policies (Lijun)");
                Console.WriteLine("2. Create New Policy (Darren)");
                Console.WriteLine("3. Edit Policy (Haiqel)");
                Console.WriteLine("4. Send Email Alerts for policies with premium due (LiJun)");


                if (Convert.ToInt32(Console.ReadLine()) == 2)
                {
                    sampleAgent.createNewPolicy();
                    Console.ReadLine();
                }
                else if (Convert.ToInt32(Console.ReadLine()) == 3)
                {
                    sampleAgent.viewPolicy();
                }
            }
            else if (option == "CLIENT")
            {
                Console.WriteLine("Logged in as Client");
                Console.WriteLine("==================Client Functions==================");
                Console.WriteLine("1. View customer Policies(Wei Xing)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {

                    //sample client
                    Client weixing = new Client();
                    weixing.AccNo = 2;
                    weixing.Address = "Fajar Road";
                    weixing.UserID = 2;

                    //sample Policy
                    Policy p1 = new Policy();
                    p1.PolicyNum = 1;
                    p1.ExpiryDate = DateTime.Today.AddYears(1);
                    p1.Paid = false;
                    p1.setState(p1.lapsedState);
                    weixing.PolicyList.Add(p1);
                    Policy p2 = new Policy();
                    p2.PolicyNum = 2;
                    p2.Paid = false;
                    p2.setState(p2.lapsedState);
                    weixing.PolicyList.Add(p2);
                    Policy p3 = new Policy();
                    p3.PolicyNum = 3;
                    p3.Paid = true;
                    weixing.PolicyList.Add(p3);
                    weixing.viewPolicy();
                    Console.WriteLine("Please select index of policy to pay premium by credit card");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    weixing.PolicyList[choice - 1].payPremium();
                    Console.ReadLine();

                    
                }


            }
                    

            

                
            }
        }
    }

