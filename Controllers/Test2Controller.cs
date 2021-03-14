using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        [HttpGet]   // GET /api/test2
        public IActionResult ListProducts()
        {
            return new StatusCodeResult(400);
            
        }

        [HttpGet("{id}")]   // GET /api/test2/xyz
        public IActionResult GetProduct(string id)
        {
        return new StatusCodeResult(404);
        }

        [HttpGet("int/{id:int}")] // GET /api/test2/int/3
        public IActionResult GetIntProduct(int id)
        {
        return new StatusCodeResult(409);
        }

        [HttpGet("int2/{id}")]  // GET /api/test2/int2/3
        public IActionResult GetInt2Product(int id)
        {
            
            return new StatusCodeResult(415);
        }
    }
}