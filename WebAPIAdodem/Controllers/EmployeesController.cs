using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebAPIAdodem.Controllers
{
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public IEnumerable<spGetEmployeesByLastName_Result> GetByLn(string term)
        {
            using (CompanyEntities entities = new CompanyEntities())
            {
                
                return entities.spGetEmployeesByLastName(term);
                //return entities.Employees.FirstOrDefault(e => e.EmpLn == term);
            }
        }
    }
}
