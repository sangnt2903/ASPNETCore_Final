using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Controllers
{
    public class NganLuongController : Controller
    {
        private readonly ESHOPContext db;
        public NganLuongController(ESHOPContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExecutePayment(string buyer_fullname, string buyer_email,
            string buyer_mobile, string option_payment, string bankcode)
        {
            string payment_method = option_payment;
            string str_bankcode = bankcode;


            RequestInfo info = new RequestInfo();
            info.Merchant_id = "48246";
            info.Merchant_password = "f50caee66338f38d87988530fbb85a79";
            info.Receiver_email = "duansupper@gmail.com";



            info.cur_code = "vnd";
            info.bank_code = str_bankcode;


            int id_new = db.HoaDon.Max(m => m.MaHd)+1;
            DateTime currentDate = DateTime.Now;
            Voucher voucher = db.Voucher.SingleOrDefault(s => s.NgayBatDau <= currentDate && s.NgayHetHan >= currentDate);
            double giamGia = 0;
            if (voucher != null)
            {
                giamGia = (double)voucher.GiamGia;
            }
            double totalAmount = 0;
            List<CartItem> listCartItem = HttpContext.Session.Get<List<CartItem>>("GioHang");
            totalAmount = listCartItem.Sum(s => s.ThanhTien) * (1 - giamGia);

            info.Order_code = (id_new+1).ToString();
            info.Total_amount = totalAmount.ToString();
            info.fee_shipping = "0";
            info.Discount_amount = giamGia.ToString();
            info.order_description = "Thanh toan test thu dong hang";
            info.return_url = "http://localhost";
            info.cancel_url = "http://localhost";

            info.Buyer_fullname = buyer_fullname;
            info.Buyer_email = buyer_email;
            info.Buyer_mobile = buyer_mobile;

            APICheckoutV3 objNLChecout = new APICheckoutV3();
            ResponseInfo result = objNLChecout.GetUrlCheckout(info, payment_method);

            if (result.Error_code == "00")
            {
                
               SaveOrder(totalAmount, "nganluong");
                return Redirect(result.Checkout_url);
                //Response.Redirect(result.Checkout_url);
            }
            else
                return View();
            // txtserverkt.InnerHtml = result.Description;

        }

        public IActionResult UpdateNganLuongState()
        {
            int id_Max = db.HoaDonThanhToan.Max(m => m.MaHtttHd);
            var result = db.HoaDonThanhToan.SingleOrDefault(s => s.MaHtttHd == id_Max);
            if(result == null)
            {
                return Content("Thanh toán thất bại !");
            }
            result.TrangThaiTt = true;
            db.SaveChanges();
            return RedirectToAction("Index", "GioHang");
        }
        public List<CartItem> Carts
        {
            get
            {
                List<CartItem> myCart = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (myCart == default(List<CartItem>))
                {
                    myCart = new List<CartItem>();
                }

                return myCart;
            }
        }

        public IActionResult SaveOrder(double totalCount, string type)
        {
            try
            {
                KhachHang kh = HttpContext.Session.Get<KhachHang>("user");
                if (kh != null && type == "nganluong")
                {

                    DateTime currentDate = DateTime.Now;
                    Voucher voucher = db.Voucher.SingleOrDefault(s => s.NgayBatDau <= currentDate && s.NgayHetHan >= currentDate);
                    double giamGia = 0;
                    if (voucher != null)
                    {
                        giamGia = (double)voucher.GiamGia;
                    }


                    HoaDon hd = new HoaDon();
                    hd.MaKh = kh.MaKh;
                    hd.NgayDat = DateTime.Now;
                    hd.NgayGiao = DateTime.Now;
                    hd.HoTen = kh.HoTen;
                    hd.DiaChi = kh.DiaChi;
                    hd.SdtNguoinhan = kh.DienThoai;
                    hd.MaTrangThai = 1;
                    hd.PhiVanChuyen = 35000;
                    hd.TongTienHang = (1 - giamGia) * totalCount;
                    db.HoaDon.Add(hd);
                    db.SaveChanges();

                    int id_HD = db.HoaDon.Max(m => m.MaHd);
                    HoaDonThanhToan hdtt = new HoaDonThanhToan();
                    hdtt.MaHd = id_HD;
                    hdtt.MaHttt = "nganluong";
                    hdtt.TrangThaiTt = true;
                    db.HoaDonThanhToan.Add(hdtt);
                    db.SaveChanges();

                    foreach (var item in Carts)
                    {
                        ChiTietHd cthd = new ChiTietHd();
                        cthd.MaHd = item.MaHh;
                        cthd.MaHh = item.MaHh;
                        cthd.DonGia = item.GiaBan;

                        cthd.GiamGia = giamGia;
                        cthd.SoLuong = item.SoLuong;
                        cthd.KichCo = item.KichCo;
                        db.ChiTietHd.Add(cthd);
                        db.SaveChanges();
                        HttpContext.Session.Remove("GioHang");

                    }
                    return new JsonResult(true);
                }

            }
            catch
            {
            }
            return new JsonResult(false);
        }
    }
}