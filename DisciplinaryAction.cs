using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class DisciplinaryAction
    {

        public string TypeOfAction {  get; set; }
        public DateTime DateOfAction { get; set; }
        public string OrderNumber {  get; set; }

        public DisciplinaryAction(string typeOfAction, DateTime dateOfAction, string orderNumber)
        {
            TypeOfAction = typeOfAction;
            DateOfAction = dateOfAction;
            OrderNumber = orderNumber;
        }
    }
}
