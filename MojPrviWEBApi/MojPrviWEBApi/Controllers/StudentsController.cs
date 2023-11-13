/*
 **********************************
 * Author: Josip Sanader
 * Project Task: Company
 **********************************
 * Description:
 *  
 *  A program that lists employees of a certain company.
 *  It consists of 3 endpoints:
 *      - get employee and company name from Route
 *      - get employee and company name from Query
 *      - get company name from Body
 *      
 **********************************
 */

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MojPrviWEBApi.Controllers
{
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        [Route("/route/{employeeName}/{companyName}")]
        public IActionResult Endpoint1([FromRoute]string employeeName, [FromRoute]string companyName)
        {
            return Ok($"Employee {employeeName} employed at {companyName} Company");
        }

        [HttpGet]
        [Route("/query")]
        public IActionResult Endpoint2([FromQuery]string employeeName, [FromQuery]string companyName)
        {
            return Ok($"Employee {employeeName} employed at {companyName} Company");
        }

        [HttpPost]
        [Route("/body")]
        public IActionResult Endpoint3([FromBody]string companyName)
        {
            return Ok($"Hello from {companyName} Company!");
        }
    }
}
