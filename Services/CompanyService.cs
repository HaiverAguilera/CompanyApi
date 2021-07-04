using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CompanyService
    {
        public List<CustomTypes.Company> ValidateNit(int companyNit)
        {
            using (var db = new CompaniesEntities())
            {
                var query = db.Company.Where(c => c.IdentificationNumber.Equals(companyNit)).ToList();
                return query.Select(c => new CustomTypes.Company
                {
                    Id = c.Id,
                    IdentificationNumber = c.IdentificationNumber,
                    IdentificationType = c.IdentificationType,
                    CompanyName = c.CompanyName,
                    FirstName = c.FirstName,
                    SecondName = c.SecondName,
                    FirstLastName = c.FirstLastName,
                    SecondLastName = c.SecondLastName,
                    Email = c.Email,
                    AuthorizeCellPhoneMessages = c.AuthorizeCellPhoneMessages,
                    AuthorizeEmailMessages = c.AuthorizeEmailMessages
                }).ToList();
            }
        }

        public bool Update(CustomTypes.Company company)
        {
            using (var db = new CompaniesEntities())
            {
                var companyInDb = db.Company.FirstOrDefault(c => c.Id.Equals(company.Id));
                if (companyInDb != null)
                {
                    companyInDb.IdentificationType = company.IdentificationType;
                    companyInDb.CompanyName = company.CompanyName;
                    companyInDb.FirstLastName = company.FirstLastName;
                    companyInDb.SecondLastName = company.SecondLastName;
                    companyInDb.FirstName = company.FirstName;
                    companyInDb.SecondName = company.SecondName;
                    companyInDb.Email = company.Email;
                    companyInDb.AuthorizeCellPhoneMessages = company.AuthorizeCellPhoneMessages;
                    companyInDb.AuthorizeEmailMessages = company.AuthorizeEmailMessages;
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
