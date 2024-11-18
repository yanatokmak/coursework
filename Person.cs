using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Person
    {
        public enum gender
        {Male, Female}
        
        public string Surname { get; set; } 
        public string Name { get; set; }
        public gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string HomeAddress {  get; set; }  
        public string PhoneNumber { get; set; }
        public string Education { get; set; }
        public string EducationalInstitution { get; set; }
        public int GraduationYear { get; set; }
        public string Specialty { get; set; }
        public string EducationDocumentData { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportIssueDate { get; set; }
        public string PassportIssuedBy { get; set; }
        public DateTime EmploymentStartDate { get; set; }

        public string? Patronymic { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Patronymic))
                    return $"{Surname} {Name}";
                return $"{Surname} {Name} {Patronymic}";
            }
        }

    }
}
