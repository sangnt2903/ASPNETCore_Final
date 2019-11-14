using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using PayPal.v1.Payments;
using BraintreeHttp;

namespace ASPCore_Final.Controllers
{
    public class PayPalController : Controller
    {
        private readonly ESHOPContext db;
        private SandboxEnvironment environment;
        private PayPalHttpClient _client;
        public PayPalController(ESHOPContext ctx)
        {
            environment = new SandboxEnvironment("AXQGDKCc8Q4HNj3CmqQzipkha8qZy_RdJXKihaZ8Pp5sPChWW8RyCQ544XJCrGXgc42VDD4DcD7KIKcR", "EGL1Sorwr0fxp7cRXxVL12VaI9rAH9RysBslu9KiDnuxEESkf8DVC-DjqAXrqOn9Ufi1dcYzC34rLFye");
            _client = new PayPalHttpClient(environment);
            db = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }
               
                return data;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(string hoten_ngnhan, string dc_nguoinhan, string ghichu, string sdt)
        {
            Thongtinhoadon tt_thanhtoan = new Thongtinhoadon
            {
                HoTen_NgNhan = hoten_ngnhan,
                Dia_Chi = dc_nguoinhan,
                Ghi_Chu = ghichu,
                Sdt = sdt
            };
            HttpContext.Session.Set<Thongtinhoadon>("thongtin-thanhtoan",tt_thanhtoan);
            //SandboxEnvironment(clientId, clientSerect)
            
            
            //Đọc thông tin đơn hàng từ Session
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            var tongTien = Cart.Sum(p => p.ThanhTien);
            foreach (var item in Cart)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.TenHh,
                    Currency = "USD",
                    Price = item.GiaBan.ToString(),
                    Quantity = item.SoLuong.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = tongTien.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = tongTien.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Thanh toán đơn hàng ESHOP",
                        InvoiceNumber = DateTime.Now.Ticks.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://localhost:44318/Paypal/Fail",
                    ReturnUrl = "https://localhost:44318/Paypal/Success"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                BraintreeHttp.HttpResponse response = await _client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();
                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
                return RedirectToAction("Fail");
            }

            return View();
        }

        public IActionResult Success(string paymentID, string token, string PayerID)
        {
            var getKH = HttpContext.Session.Get<KhachHang>("user") != null ? HttpContext.Session.Get<KhachHang>("user") : db.KhachHang.SingleOrDefault(p => p.TaiKhoan == "anonymouse");
            Thongtinhoadon thongtinhoadon = HttpContext.Session.Get<Thongtinhoadon>("thongtin-thanhtoan");
            HoaDon hd = new HoaDon()
            {
                MaKh = getKH.MaKh,
                HoTen = thongtinhoadon.HoTen_NgNhan,
                DiaChi = thongtinhoadon.Dia_Chi,
                NgayDat = DateTime.Now,
                GhiChu = thongtinhoadon.Ghi_Chu,
                SdtNguoinhan = thongtinhoadon.Sdt,
                MaTrangThai = 0,
                PhiVanChuyen = 2,
                MaVoucher = null
            };

            db.HoaDon.Add(hd);

            // tạo chi tiết hóa đơn
            //  double tt = 0;
            double tongtienhang = 0;
            double tongthucthu = 0;

            foreach (var item in Cart)
            {
                tongtienhang += item.ThanhTien;
                HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == item.MaHh);
                //   tt = item.SoLuong * hh.DonGia * (1 - hh.GiamGia);
                ChiTietHd cthd = new ChiTietHd
                {
                    MaHd = hd.MaHd,
                    MaHh = item.MaHh,
                    DonGia = hh.DonGia,
                    GiamGia = hh.GiamGia,
                    SoLuong = item.SoLuong,
                    KichCo = item.KichCo
                };

                db.ChiTietHd.Add(cthd);
                db.SaveChanges();

            }
            hd.TongTienHang = tongtienhang;
            hd.TongThucThu = tongthucthu;
            db.SaveChanges();

            HttpContext.Session.Set<string>("mess", "Hóa đơn của bạn đã được gửi tới cửa hàng vui lòng chờ kiểm tra mail để biết trạng thái đơn hàng của bạn . ESHOP");
            HttpContext.Session.Remove("GioHang");
            HoaDonThanhToan hoaDonThanhToan = new HoaDonThanhToan
            {
                MaHd = hd.MaHd,
                MaHttt = "paypal",
                TrangThaiTt = true
            };

            db.HoaDonThanhToan.Add(hoaDonThanhToan);
            db.SaveChanges();
            //Tạo đơn hàng trong CSDL với trạng thái : Đã thanh toán, phương thức: Paypal
            return View();
        }

        public IActionResult Fail()
        {
            var getKH = HttpContext.Session.Get<KhachHang>("user") != null ? HttpContext.Session.Get<KhachHang>("user") : db.KhachHang.SingleOrDefault(p => p.TaiKhoan == "anonymouse");
            Thongtinhoadon thongtinhoadon = HttpContext.Session.Get<Thongtinhoadon>("thongtin-thanhtoan");
            HoaDon hd = new HoaDon()
            {
                MaKh = getKH.MaKh,
                HoTen = thongtinhoadon.HoTen_NgNhan,
                DiaChi = thongtinhoadon.Dia_Chi,
                NgayDat = DateTime.Now,
                GhiChu = thongtinhoadon.Ghi_Chu,
                SdtNguoinhan = thongtinhoadon.Sdt,
                MaTrangThai = 0,
                PhiVanChuyen = 2,
                MaVoucher = null
            };

            db.HoaDon.Add(hd);

            // tạo chi tiết hóa đơn
            //  double tt = 0;
            double tongtienhang = 0;
            double tongthucthu = 0;

            foreach (var item in Cart)
            {
                tongtienhang += item.ThanhTien;
                HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == item.MaHh);
                //   tt = item.SoLuong * hh.DonGia * (1 - hh.GiamGia);
                ChiTietHd cthd = new ChiTietHd
                {
                    MaHd = hd.MaHd,
                    MaHh = item.MaHh,
                    DonGia = hh.DonGia,
                    GiamGia = hh.GiamGia,
                    SoLuong = item.SoLuong,
                    KichCo = item.KichCo
                };

                db.ChiTietHd.Add(cthd);
                db.SaveChanges();

            }
            hd.TongTienHang = tongtienhang;
            hd.TongThucThu = tongthucthu;
            db.SaveChanges();

            HttpContext.Session.Set<string>("mess", "Hóa đơn của bạn đã được gửi tới cửa hàng vui lòng chờ kiểm tra mail để biết trạng thái đơn hàng của bạn . ESHOP");
            HttpContext.Session.Remove("GioHang");
            HoaDonThanhToan hoaDonThanhToan = new HoaDonThanhToan
            {
                MaHd = hd.MaHd,
                MaHttt = "paypal",
                TrangThaiTt = false
            };

            db.HoaDonThanhToan.Add(hoaDonThanhToan);
            db.SaveChanges();
            //Tạo đơn hàng trong CSDL với trạng thái : Chưa thanh toán, phương thức: 
            return View();
        }
    }
}