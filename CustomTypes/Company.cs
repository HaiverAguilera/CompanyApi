using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Company
    {
        public int Id { get; set; }
        public string IdentificationType { get; set; }
        public int IdentificationNumber { get; set; }
        public string FullName { get {
                return FirstName + " " + SecondName + " " + FirstLastName + " " + SecondLastName;
            }}
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public bool? AuthorizeCellPhoneMessages { get; set; }
        public bool? AuthorizeEmailMessages { get; set; }
    }
}
