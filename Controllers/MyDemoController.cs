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
    public class MyDemoController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        public IActionResult MyIndex(int? id)
        {
            return View();
        }

        [Route("Home/About")]
        [Route("Home/About/{id?}")]
        public IActionResult MyAbout(int? id)
        {
            return View("Movies/Edit");
        }
    }
}