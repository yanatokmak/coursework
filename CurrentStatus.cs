using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class CurrentStatus : Person
    {
        public enum academicDegree { None, CandidateOfSciences, DoctorOfSciences}
        public enum academicTitle { None, Docent, Professor}
        

        public string Department { get; set; }
        public string JobTitle { get; set; }
        public academicDegree AcademicDegree { get; set; } 
        public academicTitle AcademicTitle { get; set; } 
        public List<PreviousJob> PreviousJobs { get; set; } = new List<PreviousJob>();
        public List<JobMovement> JobMovements { get; set; } = new List<JobMovement>();
        public List<DisciplinaryAction> DisciplinaryActions { get; set; } = new List<DisciplinaryAction>();
        public List<Incentive> Incentives { get; set; } = new List<Incentive>();

    }
}
