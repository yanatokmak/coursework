using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class JobMovement
    {
        public string MovementReason { get; set; }  
        public DateTime MovementDate {  get; set; }
        public string OrderNumber { get; set; }
        public JobMovement(string movementReason, DateTime movementDate, string orderNumber)
        {
            MovementReason = movementReason;
            MovementDate = movementDate;
            OrderNumber = orderNumber;
        }
    }
}
