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
            return View("../Movies/Index");
        }

        [HttpPost("/products3")]
        public IActionResult CreateProduct(Movie myProduct)
        {
            return View("../Movies/Create"); 
        }
    }
}
