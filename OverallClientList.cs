using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    class OverallClientList
    {
        private static OverallClientList overallClientList = new OverallClientList();
        public static OverallClientList Clients
        {
            get { return overallClientList; }
        }
        public static List<Client> ClientList { get; set; }
        

        private OverallClientList()
        {
            ClientList = new List<Client>();
            Client john = new Client();
            john.AccNo = 1;
            john.Name = "John";
            john.UserID = 1;
            ClientList.Add(john);
        }
    }
}
