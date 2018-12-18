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

        
        public IActionResult Index(string loai="", bool? gioitinh = null, int page = 1, int pageSize = 6)
        {
            int starIndex = (page - 1) * pageSize;
            List<HangHoa> hangHoas =  db.HangHoa.Skip(starIndex).ToList();
            if (gioitinh != null)
            {
                hangHoas = db.HangHoa.Where(p => p.MaLoaiNavigation.GioiTinh == gioitinh).Skip(starIndex).ToList();
            }
            else if(loai != null && loai != "")
            {
                hangHoas = db.HangHoa.Where(p => p.MaLoai == loai).Skip(starIndex).ToList();
            }
            int itemsize = hangHoas.Count < pageSize ? hangHoas.Count : pageSize;
            List<HangHoa> res = hangHoas.Take(itemsize).ToList();   
            
            return View("Index",res);
        }

        public List<HangHoaAjaxModel> TaiThem(string loai = "", bool? gioitinh = null, int page = 2, int pageSize = 6)
        {
            int starIndex = (page - 1) * pageSize;
            List<HangHoa> hangHoas = db.HangHoa.Skip(starIndex).ToList();
            if (gioitinh != null)
            {
                hangHoas = db.HangHoa.Where(p => p.MaLoaiNavigation.GioiTinh == gioitinh).Skip(starIndex).ToList();
            }
            else if (loai != null && loai != "")
            {
                hangHoas = db.HangHoa.Where(p => p.MaLoai == loai).Skip(starIndex).ToList();
            }
            int itemsize = hangHoas.Count < pageSize ? hangHoas.Count : pageSize;
            List<HangHoa> resHH = hangHoas.Take(itemsize).ToList();
            List<HangHoaAjaxModel> res = new List<HangHoaAjaxModel>();
            foreach (var item in resHH)
            {
                List<SanPhamKho> sanPhamKhos = db.SanPhamKho.Where(p => p.MaHh == item.MaHh).ToList();
                var soluong = sanPhamKhos.Sum(x => x.SoLuong);
                string ghiChu = "";
                if (soluong > 10)
                {
                    double gg = item.GiamGia * 100;
                    ghiChu = "-" + gg + "%";
                }
                else if (soluong > 0)
                {
                    ghiChu = "Sắp hết hàng";
                }
                else
                {
                    ghiChu = "Tạm hết hàng";
                }

                List<YeuThich> yts = db.YeuThich.Where(p => p.MaHh == item.MaHh).ToList();
                double diemyt = 0;
                int diem = 5;
                if (yts.Count > 0)
                {
                    double tongdiem = 0;
                    foreach (var y in yts)
                    {
                        tongdiem = tongdiem + y.DiemDanhGia;
                    }
                    diemyt = tongdiem / yts.Count();
                    diem = int.Parse(diemyt.ToString().Split(".")[0]);
                    if (diem < 3)
                    {
                        diem = 3;
                    }
                }

                double giaBan = item.DonGia * (1 - item.GiamGia);

                HangHoaAjaxModel hhModel = new HangHoaAjaxModel
                {
                    MaHh = item.MaHh,
                    TenHh = item.TenHh,
                    Hinh = item.Hinh,
                    GhiChu = ghiChu,
                    Diem = diem,
                    DonGia = item.DonGia,
                    GiamGia = item.GiamGia,
                    GiaBan = giaBan,
                    MoTa = item.MoTa,
                    MaLoai = item.MaLoai,
                    MaNcc = item.MaNcc
                };
                res.Add(hhModel);
            }
            return res;
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

        public IActionResult ThemDanhGia(int mahh,string noidung,double rating)
        {
            if(HttpContext.Session.Get<KhachHang>("user") != null)
            {
                if(ViewBag.ErrorCmt != null)
                {
                    ViewBag.ErrorCmt = null;
                }
                BinhLuanSp cmt = new BinhLuanSp
                {
                    NoiDung = noidung,
                    NgayBl = DateTime.Now,
                    MaKh = HttpContext.Session.Get<KhachHang>("user").MaKh,
                    MaHh = mahh
                };
                HangHoa hh = db.HangHoa.SingleOrDefault(p=>p.MaHh == mahh);
                KhachHang kh = HttpContext.Session.Get<KhachHang>("user");
                
                db.BinhLuanSp.Add(cmt);
               
                db.SaveChanges();
                YeuThich yt = new YeuThich
                {
                    MaHh = hh.MaHh,
                    MaKh = kh.MaKh,
                    NgayChon = DateTime.Now,
                    DiemDanhGia = rating,
                    MaBl = cmt.MaBl
                };
                db.YeuThich.Add(yt);
                db.SaveChanges();
                return View("ChiTiet", hh);
            }
            else
            {
                HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);
                ViewBag.ErrorCmt = "Vui lòng đăng nhập để bình luận";
                return View("ChiTiet",hh);
            }
        }
    }
}