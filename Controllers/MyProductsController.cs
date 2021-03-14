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
    [ApiController]
    public class MyProductsController : Controller
    {
        [HttpGet("/products3")]
        public IActionResult ListProducts()
        {
            return new StatusCodeResult(400);
        }

        [HttpPost("/products3")]
        public IActionResult CreateProduct(Movie myProduct)
        {
            return new StatusCodeResult(500);
        }
    }
    [ApiController]
    public class Products2ApiController : ControllerBase
    {
        [HttpGet("/products2/{id}", Name = "Products_List")]
        public IActionResult GetProduct(int id)
        {
            return new StatusCodeResult(404);
        }
    }
    [ApiController]
    [Route("products")]
    public class ProductsApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListProducts()
        {
            return new StatusCodeResult(206);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return new StatusCodeResult(303);
        }
    }

    [Route("Home2")]
    public class Home2Controller : Controller
    {
        [Route("")]
        [Route("Index")]
        [Route("/")]
        public IActionResult Index()
        {
            return new StatusCodeResult(307);
        }

        [Route("About")]
        public IActionResult About()
        {
            return new StatusCodeResult(308);
        }
    }
}
