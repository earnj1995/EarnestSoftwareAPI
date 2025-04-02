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
public class ProductController : ControllerBase
{
    private readonly DAL.DAL _dal;

    public ProductController(DAL.DAL dal)
    {
        _dal = dal;
    }

    [HttpPost("GetProducts")]
    public async Task<ActionResult> GetProducts([FromBody] Page page)
    {
        var products = await _dal.GetProducts(page);
        return Ok(products);
    }
}
}