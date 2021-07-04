using CompanyApi.Models;
using CustomTypes;
using Services;
using System;
using System.Net;
using System.Web.Http;

namespace CompanyApi.Controllers
{
    public class CompanyController : ApiController
    {
        private CompanyService _companyService;

        public CompanyController()
        {
            _companyService = new CompanyService();
        }
        
        [HttpGet]
        public ServiceResponse ValidateNit([FromUri] int companyNit)
        {
            try
            {
                var companies = _companyService.ValidateNit(companyNit);
                var exceptionResponse = "";

                if (companies == null || companies.Count == 0)
                {
                    exceptionResponse = "La identificación de la empresa no está registrada.";
                }

                return new ServiceResponse
                {
                    Code = companies != null && companies.Count > 0 ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest,
                    Data = companies,
                    Exception = exceptionResponse
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Exception = ex.ToString()
                };
            }
        }

        [HttpPost]
        public ServiceResponse Update(Company company)
        {
            try
            {
                var updateResult = _companyService.Update(company);
                var exceptionResponse = "";
                if (!updateResult)
                {
                    exceptionResponse = "No se actualizaron los datos. Revise los campos de nuevo.";
                }
                return new ServiceResponse
                {
                    Code = updateResult == true ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest,
                    Data = updateResult,
                    Exception = exceptionResponse
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Exception = ex.ToString()
                };
            }
        }
    }
}
