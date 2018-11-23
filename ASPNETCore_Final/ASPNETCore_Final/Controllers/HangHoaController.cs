using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Final.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly ESHOPContext db;

        public HangHoaController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index(int? id)
        {
            List<HangHoa> hangHoas = db.HangHoa.Where(p => p.MaLoai == id).Select(p => new HangHoa
            {
                MaHh = p.MaHh,
                TenHh = p.TenHh,
                Hinh = p.Hinh,
                DonGia = p.DonGia,
                GiamGia = p.GiamGia,
                MoTa =p.MoTa,
            }).ToList();
            Loai loai = db.Loai.SingleOrDefault(p => p.MaLoai == id);
            ViewBag.TenLoai = loai.TenLoai;
            return View(hangHoas);
        }

        public IActionResult ChiTiet(int? id)
        {
            HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == id);
            return View(hh);
        }
    }
}