using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ASPCore_Final.Models;
using Twilio.Rest.Api.V2010.Account;
using Twilio;
using System.Collections.Generic;
using Twilio.Rest.Verify.V2;
using Twilio.Rest.Verify.V2.Service;
using System;
using Twilio.Types;
using Microsoft.AspNetCore.Http;

namespace ASPCore_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SendSMSController : Controller
    {
        private readonly ESHOPContext db;
        public static VerifyPhoneModel verifyPhone;
        private readonly string accountSid = "AC4fcc225a99211f56fc6ef2927d38791c";
        private readonly string authToken = "b6f018ac536c849a5acdffd06b91ab7c";
        private string defaultCurrent = "friendly";
        public SendSMSController(ESHOPContext _db)
        {
            db = _db;
        }

        //public ServiceResource InitService()
        //{
            
        //}

        public List<KhachHang> ListToSend
        {
            get
            {
                List<KhachHang> myList = HttpContext.Session.Get<List<KhachHang>>("ListToSend");
                if (myList == default(List<KhachHang>))
                {
                    myList = new List<KhachHang>();
                }

                return myList;
            }
        }

        [HttpGet("/admin/SendSMS")]
        public IActionResult Index()
        {
            List<KhachHang> listToSend = new List<KhachHang>();

            if (defaultCurrent == "all")
            {
                listToSend = db.KhachHang.Where(p => p.PhoneNumberComfirmed == true).ToList();
            }
            else if (defaultCurrent == "friendly")
            {
                listToSend = db.KhachHang.Where(p => p.PhoneNumberComfirmed == true && p.LoaiKH == true).ToList();
            }
            else if(defaultCurrent == "normal")
            {
                listToSend = db.KhachHang.Where(p => p.PhoneNumberComfirmed == true && p.LoaiKH == false).ToList();
            }

            HttpContext.Session.Set("ListToSend", listToSend);
            return View(ListToSend);
        }

        [HttpPost("/admin/SendSMS/Send")]
        public IActionResult Send(string mess)
        {
            TwilioClient.Init(accountSid, authToken);
            List<string> messSidList = new List<string>();
            foreach (var kh in ListToSend)
            {
                    string friendlyPhoneNumber = "+84";
                    friendlyPhoneNumber += kh.DienThoai.First() == '0' ? kh.DienThoai.Remove(0, 1) : kh.DienThoai;
                    var message = MessageResource.Create(
                        body: mess,
                        from: new Twilio.Types.PhoneNumber("+12036842510"), // numberphone đăngkí active
                        to: new Twilio.Types.PhoneNumber(friendlyPhoneNumber)
                    );
                    messSidList.Add(message.Sid);
            }

            ViewBag.ListSent = messSidList;
            return View("Index", ListToSend);
        }

        public List<KhachHang> UpdateListToSend(string typeListToChosen)
        {
            List<KhachHang> listToSend = new List<KhachHang>();
            if (typeListToChosen == "all")
            {
                listToSend = db.KhachHang.Where(p => p.PhoneNumberComfirmed == true).ToList();
            }
            else if (typeListToChosen == "friendly")
            {
                listToSend = db.KhachHang.Where(p => p.PhoneNumberComfirmed == true && p.LoaiKH == true).ToList();
            }
            else if (typeListToChosen == "normal")
            {
                listToSend = db.KhachHang.Where(p => p.PhoneNumberComfirmed == true && p.LoaiKH == false).ToList();
            }

            HttpContext.Session.Set("ListToSend", listToSend);
            return ListToSend;
        }

        //**********************************************
        //fix VERIFY CODE WHEN SIGN UP 
        //*******************************************

        [HttpGet("/admin/SendSMS/RegisterNumberphoneToVerify")]
        public IActionResult RegisterNumberphoneToVerify()
        {
            return View();
        }

        

        [HttpPost]
        public IActionResult RegisterNumberphoneToVerify(int countryCode, string phoneNumber)
        {

            TwilioClient.Init(accountSid, authToken);
            var _service = ServiceResource.Create(friendlyName: "Code Eshop của bạn là:");

            //custom phone number
            string friendlyPhoneNumber = "+" + countryCode.ToString();
            friendlyPhoneNumber += phoneNumber.First() == '0' ? phoneNumber.Remove(0, 1) : phoneNumber;

            //create verification
            CreateVerificationOptions options = new CreateVerificationOptions(pathServiceSid: _service.Sid, to: friendlyPhoneNumber, channel: "sms");
            var verification = VerificationResource.Create(options);

            //Save phone number
            verifyPhone = new VerifyPhoneModel
            {
                CountryCode = countryCode,
                PhoneNumber = phoneNumber
            };

            HttpContext.Session.Set("verSid_serSid", verification.Sid+","+_service.Sid);
            HttpContext.Session.Set<string>("statusVerify",verification.Status.ToString());

            return RedirectToAction("CheckVerifiedCode");
        }

        [HttpGet("/admin/SendSMS/CheckVerifiedCode")]
        public IActionResult CheckVerifiedCode()
        {
            ConfirmPhoneModel confirm = new ConfirmPhoneModel
            {
                DialingCode = verifyPhone.CountryCode,
                PhoneNumber = verifyPhone.PhoneNumber,
            };
            return View(confirm);
        }

        [HttpPost]
        public IActionResult CheckVerifiedCode(ConfirmPhoneModel confirm)
        {
            TwilioClient.Init(accountSid, authToken);
            //var _service = ServiceResource.Create(friendlyName: "My send message");
            //custom number phone

            string friendlyPhoneNumber = "+" + confirm.DialingCode.ToString();
            friendlyPhoneNumber += confirm.PhoneNumber.First() == '0' ? confirm.PhoneNumber.Remove(0, 1) : confirm.PhoneNumber;


            //xác minh số điện thoại thành verified caller id

            //var phoneNumber = new PhoneNumber(friendlyPhoneNumber);
            //var validationRequest = ValidationRequestResource.Create(
            //    phoneNumber,
            //    friendlyName: friendlyPhoneNumber
            //);

            string Sid = HttpContext.Session.Get<string>("verSid_serSid");
            if (Sid != null)
            {
                var verSid = Sid.Split(",")[0];
                var serSid = Sid.Split(",")[1];
                //check verify
                var verificationCheck = VerificationCheckResource.Create(
                    to: friendlyPhoneNumber,
                    verificationSid: verSid,
                    pathServiceSid: serSid,
                    code: confirm.VerificationCode
                );

                if (verificationCheck.Valid == true && verificationCheck.Status == "approved")
                {
                    //update sdt db if it has
                    List<KhachHang> khachHangs = db.KhachHang.Where(p => p.DienThoai == confirm.PhoneNumber).ToList();
                    if(khachHangs.Count > 0)
                    {
                        foreach (var kh in khachHangs)
                        {
                            kh.PhoneNumberComfirmed = true;
                        }

                        db.SaveChanges();
                    } else
                    {
                        KhachHang kh = new KhachHang {
                            TaiKhoan = "anonymouse",
                            HoTen = "anonymouse",
                            NgaySinh = DateTime.Now,
                            DienThoai = confirm.PhoneNumber,
                            GioiTinh = "Nam",
                            Email = "anonymous@gmail.com",
                            TrangThaiHd = false,
                            LoaiKH = false,
                            PhoneNumberComfirmed = true
                        };

                        db.KhachHang.Add(kh);
                        db.SaveChanges();
                    }
                    

                    HttpContext.Session.Remove("verSid_serSid");
                    return View("Success");
                }
                else
                {
                    ViewBag.errorCodeVerify = "Code is invalid. Please enter your valid code or resend";
                    return RedirectToAction();
                }
            }
            else
            {
                ViewBag.ErrorVerSid = "Có vẻ như bạn chưa được gửi mã verify Code. Vui lòng nhấn resend để gửi lại";
                return View("CheckVerifiedCode",confirm);
            }
            
        }

        public IActionResult Success()
        {
            return View();
        }
        
    }
}