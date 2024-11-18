using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Incentive
    {
        public string TypeOfIncentive { get; set; }
        public DateTime DateOfIncentive { get; set; }
        public string OrderNumber { get; set; }

        public Incentive(string typeOfIncentive, DateTime dateOfIncentive, string orderNumber)
        {
            TypeOfIncentive = typeOfIncentive;
            DateOfIncentive = dateOfIncentive;
            OrderNumber = orderNumber;
        }  
    }
}
