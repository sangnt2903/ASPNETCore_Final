using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore_Final.Models;

namespace ASPCore_Final.Controllers
{
    public class LoginController : Controller
    {
        private readonly ESHOPContext db;
        public LoginController(ESHOPContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginKH model)
        {
            if (ModelState.IsValid)
            {
                KhachHang kh = db.KhachHang.SingleOrDefault(p => p.TaiKhoan == model.Username && p.MatKhau == Encryptor.MD5Hash(model.Password) && p.TrangThaiHd != false);
                if (kh == null)
                {
                    ModelState.AddModelError("Lỗi", "Tên đăng nhập hoặc mật khẩu không hợp lệ. Hoặc tài khoản bạn chưa hoạt động vui lòng kiểm tra mail để kích hoạt tài khoản");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.Set("user", kh);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Index");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            if (HttpContext.Session.Get<string>("mess") != null)
                HttpContext.Session.Remove("mess");
            return RedirectToAction("Index", "Login");
        }
    }
}