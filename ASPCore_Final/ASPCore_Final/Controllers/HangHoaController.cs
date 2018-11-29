using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly ESHOPContext db;
        public HangHoaController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index(string loai, int page = 1, int pageSize = 6)
        {
            int starIndex = (page - 1) * pageSize;
            List<HangHoa> hangHoas = db.HangHoa.Where(p => p.MaLoai == loai).Skip(starIndex).ToList();
            int itemsize = hangHoas.Count < pageSize ? hangHoas.Count : pageSize;
            List<HangHoa> res = hangHoas.Take(itemsize).ToList();
            return View(res);
        }

        public IActionResult ChiTiet(int mahh)
        {
            HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);
            return View(hh);
        }

        public IActionResult TimKiem(string keyword)
        {
            List<HangHoa> hh = new List<HangHoa>();
            if(keyword != null)
            {
                hh = db.HangHoa.Where(p => p.TenHh.ToLower().Contains(keyword.ToLower())).Take(6).ToList();
            }
            return View(hh);
        }
    }
}