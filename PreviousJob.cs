using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class PreviousJob
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public DateTime WorkingStartDate { get; set; }
        public DateTime WorkingEndDate { get; set; }
        public string LastJobTitle { get; set; }
        public string ReasonForDismissal { get; set; }

        public PreviousJob(string companyName, string companyAddress, string companyPhone, DateTime workingStartDate,DateTime workingEndDate, string lastJobTitle, string reasonForDismissal)
        {
            CompanyName = companyName;
            CompanyAddress = companyAddress;
            CompanyPhone = companyPhone;
            WorkingStartDate = workingStartDate;
            WorkingEndDate = workingEndDate;
            LastJobTitle = lastJobTitle;
            ReasonForDismissal = reasonForDismissal;
        }
    }
}
