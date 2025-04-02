using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EarnestsWebApi.DAL;
using EarnestsWebApi.DTO;

namespace EarnestsWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly DAL.DAL _dal;

        public CustomerController(DAL.DAL dal)
        {
            _dal = dal;
        }

        [HttpPost("GetCustomers")]
        public async Task<ActionResult> GetCustomers([FromBody] Page page)
        {
            var customers = await _dal.GetCustomers(page);
            return Ok(customers);
        }
    }
}