using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class Program
    {
        static void Main()
        {
            // Create a list of available riders to all the policies
            // Assumption : All the different types of policies are abe to add riders that can be added to other policies as well.
            // create a fake repository for the global list of riders.
            List<Rider> globalRiderList = new List<Rider>()
            {
                new Rider(1,100.00,"Type1",200.00,0.05),
                new Rider(2,200.00,"Type2",400.00,0.07),
                new Rider(3,300.00,"Type3",900.00,0.1),
            };

            Console.WriteLine("Please login as(client/agent) : ");
            string option = Console.ReadLine().ToUpper();
            if (option == "AGENT")
            {

                Console.WriteLine("Logged in as Agent");
                Agent sampleAgent = new Agent();
                Console.WriteLine("=====================Agent Functions================");
                Console.WriteLine("1. View Policies (Lijun) + Edit Policy (Haiqel) + Pay Premium By Cheque (Haiqel) + Send Email Alert for policies with premium due (LiJun)");
                Console.WriteLine("2. Create New Policy (Darren)");
                Console.WriteLine("Note : Haiqel's Use Cases 'Edit Policy' and 'Pay Premium by cheque' codes are embedded inside 'Lijun code'");

                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    while (true)
                    {
                        // Lijun's Use Case - View Policies 

                        // attrbiutes
                        int policyNum; // the policy that the agent wants to see/edit
                        List<Policy> policiesOwned = sampleAgent.PolicyList;
                        string userInputViewPolicies; // var to store if agent wants to view other policies.
                                                      //behaviour
                        sampleAgent.viewPolicy(); // display the policies
                        Console.Write("What is the policy number that you would like to view further? : ");
                        policyNum = Convert.ToInt16(Console.ReadLine());
                        // print the specific policy to ve viewed.
                        Console.WriteLine("{0: 10} {1:10} {2:10} {3:10}", policiesOwned[policyNum-1].PolicyNum,
                                policiesOwned[policyNum-1].TermsAndConditions, policiesOwned[policyNum-1].ExpiryDate,
                                policiesOwned[policyNum-1].TotalPremiumCost);

                        //ask the agent to "Done" or View other policies
                        // Coded based on Lijun's use case description
                        Console.WriteLine("Do you wish to view other policies?");
                        Console.WriteLine("If yes, enter 'View other policies'");
                        Console.Write("If no, enter 'Done' : ");

                        // Store the user's input
                        userInputViewPolicies = Console.ReadLine();

                        // if user does not want to view policies
                        if (userInputViewPolicies == "Done")
                        {
                            // local attributes
                            string userInput1; // store the user's input;
                            List<Rider> riderList = policiesOwned[policyNum - 1].RiderList;

                            // behaviour
                            // Haiqel's Use Case - Edit Policy Starts here

                            //display the column data headers first
                            Console.WriteLine("These are the riders that this policy has at the moment!");
                            Console.WriteLine(" {0:10} {1:10} {2:10} {3:10}", "RiderID", "Premium Cost", "Premium Type", "Pay Out Amount");

                            // display a list of riders that the policy has
                            for (int i = 0; i < riderList.Count(); i++)
                            {
                                Console.WriteLine(" {0:10} {1:10} {2:10} {3:10}",riderList[i].RiderID,riderList[i].PremiumCost,riderList[i].PremiumType,riderList[i].PayOutAmount);
                            }
                            //prompt agent if agent wants to add an additional rider

                            Console.WriteLine("Do you wish to add an addtional rider to the policy?");
                            Console.Write("Yes/No : ");
                            userInput1 = Console.ReadLine();

                            if (userInput1 == "Yes")
                            {
                                while (true)
                                {
                                    //local attribute
                                    int selectedRiderID; // the user to choose the riderID to be added
                                    string userInputChoice; // Yes or No;
                                                            //behaviour

                                    //display the available riders that can be added to the policy viewed
                                    Console.WriteLine("These are the riders that are avaible to be added!");
                                    Console.WriteLine(" {0:10} {1:10} {2:10} {3:10}", "RiderID", "Premium Cost", "Premium Type", "Pay Out Amount");
                                    for (int i = 0; i < riderList.Count(); i++)
                                    {
                                        Console.WriteLine(" {0:10} {1:10} {2:10} {3:10}", globalRiderList[i].RiderID, globalRiderList[i].PremiumCost, globalRiderList[i].PremiumType,
                                            globalRiderList[i].PayOutAmount);
                                    }

                                    //Prompt the user for the riderID to be added.
                                    Console.Write("Please enter the riderID to be added to this policy!");
                                    selectedRiderID = Convert.ToInt16(Console.ReadLine());

                                    policiesOwned[policyNum - 1].editPolicy(riderList, globalRiderList, selectedRiderID);
                                    Console.WriteLine("Rider has been added successfully!");
                                    Console.WriteLine("Do you wish to add any additional riders?");
                                    Console.Write("Yes/No : ");
                                    userInputChoice = Console.ReadLine();
                                    if (userInputChoice == "Yes")
                                    {
                                        continue;
                                    }
                                    else if (userInputChoice == "No")
                                    {
                                        //local variables
                                        
                                        //behaviour
                                        // Haiqel's 2nd Use Case 'Pay Premium By Cheque".
                                        Console.WriteLine("Do you want to pay the premiums by cheque (if given by the client)?");
                                        Console.Write("Yes/No : ");
                                        userInputChoice = Console.ReadLine();

                                        if (userInputChoice == "Yes")
                                        {
                                            Console.WriteLine("Do you have the cheque given by the client for the payment?");
                                            Console.Write("Yes/No : ");
                                            userInputChoice = Console.ReadLine();

                                            // Make the policy state from whatever state to active state.
                                            policiesOwned[policyNum - 1].setState(policiesOwned[policyNum].activeState);

                                            //Inform the user that the system has ackonowledged that the premiunms has been paid by cheque
                                            Console.WriteLine("The system has successfully recorded that the premiums are paid by cheque");
                                            Console.WriteLine("Redirecting you to the main menu...");
                                            Main();
                         
                                        }
                                        else if (userInputChoice == "No")
                                        {
                                            Console.WriteLine("Policy has been updated successfully!");
                                            Console.WriteLine("Bringing you back to the menu...");
                                            Main();
                                        }

                                    }
                                }
                            }

                        }
                        else if (userInputViewPolicies == "View other policies")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            continue;
                        }
                    }
                }
                else if (Convert.ToInt32(Console.ReadLine()) == 2)
                {
                    sampleAgent.createNewPolicy();
                    Console.ReadLine();
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

