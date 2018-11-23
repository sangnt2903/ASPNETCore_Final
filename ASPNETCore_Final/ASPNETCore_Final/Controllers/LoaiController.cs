using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Final.Controllers
{
    public class LoaiController : Controller
    {
        private readonly ESHOPContext db;

        public LoaiController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DSLoai()
        {
            return View();
        }
    }
}