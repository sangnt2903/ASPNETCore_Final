#pragma checksum "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2014d08cec68430c343c04695b360eb27d3ed126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyHoaDons_Index), @"mvc.1.0.view", @"/Views/MyHoaDons/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyHoaDons/Index.cshtml", typeof(AspNetCore.Views_MyHoaDons_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 2 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2014d08cec68430c343c04695b360eb27d3ed126", @"/Views/MyHoaDons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_MyHoaDons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HuyHoaDon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyHoaDons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80px;height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XoaCTHD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" glyphicon glyphicon-trash"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_frontEnd.cshtml";

#line default
#line hidden
            DefineSection("breadcumb", async() => {
                BeginContext(256, 181, true);
                WriteLiteral("\r\n    <div class=\"breadcrumbs\">\r\n        <div class=\"container\">\r\n            <ol class=\"breadcrumb breadcrumb1 animated wow slideInLeft\" data-wow-delay=\".5s\">\r\n                <li>");
                EndContext();
                BeginContext(437, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2987442a8f3f46b6a9efe41809a0116f", async() => {
                    BeginContext(481, 75, true);
                    WriteLiteral("<span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span>Trang chủ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(560, 114, true);
                WriteLiteral("</li>\r\n                <li class=\"active\">Hóa đơn của bạn</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(677, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 19 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
 if (Context.Session.Get<KhachHang>("user") != null)
{
    KhachHang k = Context.Session.Get<KhachHang>("user");

#line default
#line hidden
            BeginContext(801, 268, true);
            WriteLiteral(@"    <h3 class=""alert alert-info"" style=""font-size:25px;"">Thông tin hóa đơn của bạn</h3>
    <div class=""bootstrap-tab animated wow slideInUp"" data-wow-delay="".5s"">
        <div class=""bs-example bs-example-tabs"" role=""tabpanel"" data-example-id=""togglable-tabs"">
");
            EndContext();
#line 25 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
              
                ESHOPContext db = new ESHOPContext();
                List<HoaDon> hd_cxl = db.HoaDon.Where(p => p.MaTrangThai == 0 && p.MaKh == k.MaKh ).ToList();
                List<HoaDon> hd_xl = db.HoaDon.Where(p => p.MaTrangThai == 1 && p.MaKh == k.MaKh).ToList();
                List<HoaDon> hd_huy = db.HoaDon.Where(p => p.MaTrangThai == 2 && p.MaKh == k.MaKh).ToList();
            

#line default
#line hidden
            BeginContext(1485, 676, true);
            WriteLiteral(@"            <ul id=""myTab"" class=""nav nav-tabs"" role=""tablist"">
                <li role=""presentation"" class=""active""><a href=""#home"" id=""home-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""home"" aria-expanded=""true"">Hóa đơn chưa xử lý</a></li>
                <li role=""presentation""><a href=""#profile"" role=""tab"" id=""profile-tab"" data-toggle=""tab"" aria-controls=""profile"">Hóa đơn đã xử lý</a></li>
            </ul>
            <div id=""myTabContent"" class=""tab-content"">
                <div role=""tabpanel"" class=""tab-pane fade in active bootstrap-tab-text"" id=""home"" aria-labelledby=""home-tab"">
                    <div class=""bootstrap-tab-text-grids"">
");
            EndContext();
#line 38 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                         foreach (var hd in hd_cxl)
                        {

#line default
#line hidden
            BeginContext(2241, 296, true);
            WriteLiteral(@"                            <div class=""row table-bordered"" style=""position:relative;background-color:lightblue"">
                                <div class=""col-md-4"" style=""text-align:left;padding:10px;"">
                                    <span>Mã đơn hàng :<span class=""text text-info""> ");
            EndContext();
            BeginContext(2538, 7, false);
#line 42 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                  Write(hd.MaHd);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 77, true);
            WriteLiteral("</span></span><br />\r\n                                    <span>Đặt ngày : ");
            EndContext();
            BeginContext(2623, 10, false);
#line 43 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                  Write(hd.NgayDat);

#line default
#line hidden
            EndContext();
            BeginContext(2633, 281, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-md-3"" style=""text-align:center;padding:10px;"">
                                    <span>Người nhận :</span><br />
                                    <span class=""text text-info"">");
            EndContext();
            BeginContext(2915, 8, false);
#line 47 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                            Write(hd.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(2923, 49, true);
            WriteLiteral("</span>\r\n                                </div>\r\n");
            EndContext();
#line 49 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                  
                                    List<ChiTietHd> chiTietHds = db.ChiTietHd.Where(p => p.MaHd == hd.MaHd).ToList();
                                    double tongtien = 0;
                                    foreach (var ct in chiTietHds)
                                    {
                                        tongtien += Convert.ToDouble(ct.SoLuong * ct.DonGia * (1 - ct.GiamGia));
                                    }
                                

#line default
#line hidden
            BeginContext(3480, 232, true);
            WriteLiteral("                                <div class=\"col-md-3\" style=\"text-align:right;padding:10px;\">\r\n                                    <span>Tổng tiền :</span><br />\r\n                                    <span class=\"text text-danger\">");
            EndContext();
            BeginContext(3713, 26, false);
#line 59 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                              Write(tongtien.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(3739, 244, true);
            WriteLiteral(" đ</span>\r\n                                </div>\r\n                                <div class=\"col-md-2 btn btn-danger\" style=\"text-align:right;margin-top: 15px;margin-left: 40px; width: 130px;color:white\">\r\n                                    ");
            EndContext();
            BeginContext(3983, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c0b3ce212948c7bf6cc011d9d8ccbb", async() => {
                BeginContext(4063, 14, true);
                WriteLiteral("Hủy đơn hàng");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahd", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                              WriteLiteral(hd.MaHd);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahd", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4081, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 65 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                             foreach (var item in chiTietHds)
                            {
                                HangHoa hh = db.HangHoa.Find(item.MaHh);
                                double giaban = Convert.ToDouble(item.DonGia * (1 - item.GiamGia));
                                double thanhtien = giaban * item.SoLuong;

#line default
#line hidden
            BeginContext(4503, 187, true);
            WriteLiteral("                                <div class=\"row table-bordered\" style=\"text-align:center\">\r\n                                    <div class=\"col-md-2 text text-info\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(4690, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd865334f1e24de0b907274797087391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4700, "~/HangHoa/", 4700, 10, true);
#line 71 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
AddHtmlAttributeValue("", 4710, hh.Hinh, 4710, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4775, 107, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col-md-4 text text-info\" style=\"padding-top:40px;\">");
            EndContext();
            BeginContext(4883, 8, false);
#line 72 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                              Write(hh.TenHh);

#line default
#line hidden
            EndContext();
            BeginContext(4891, 107, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col-md-1 text text-info\" style=\"padding-top:40px;\">");
            EndContext();
            BeginContext(4999, 11, false);
#line 73 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                              Write(item.KichCo);

#line default
#line hidden
            EndContext();
            BeginContext(5010, 107, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col-md-1 text text-info\" style=\"padding-top:40px;\">");
            EndContext();
            BeginContext(5118, 12, false);
#line 74 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                              Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(5130, 123, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col-md-1 text text-info\" style=\"padding-top:40px;text-align:right\">");
            EndContext();
            BeginContext(5254, 24, false);
#line 75 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                              Write(giaban.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(5278, 123, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col-md-1 text text-info\" style=\"padding-top:40px;text-align:right\">");
            EndContext();
            BeginContext(5402, 27, false);
#line 76 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                              Write(thanhtien.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(5429, 162, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col-md-2 text-danger\" style=\"padding-top:40px;text-align:right\">\r\n                                        ");
            EndContext();
            BeginContext(5591, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c17602032068466fa03cd6b9e75ff173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mact", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                               WriteLiteral(item.MaCt);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mact"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mact", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mact"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5709, 86, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 81 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(5826, 279, true);
            WriteLiteral(@"                            <div class=""row table-bordered"" style=""text-align:center"">
                                <div class=""col-md-3"" style=""background-color:darkcyan"">Trạng thái đơn hàng :</div>
                                <div class=""col-md-9 table-bordered"">
");
            EndContext();
#line 85 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                      
                                        TrangThai tt = db.TrangThai.SingleOrDefault(p => p.MaTrangThai == hd.MaTrangThai);
                                    

#line default
#line hidden
            BeginContext(6308, 117, true);
            WriteLiteral("                                    <div class=\"col-md-3 label label-info\">\r\n                                        ");
            EndContext();
            BeginContext(6426, 15, false);
#line 89 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                   Write(tt.TenTrangThai);

#line default
#line hidden
            EndContext();
            BeginContext(6441, 158, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <br />\r\n");
            EndContext();
#line 94 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(6626, 323, true);
            WriteLiteral(@"                    </div>
                </div>
                <div role=""tabpanel"" class=""tab-pane fade bootstrap-tab-text"" id=""profile"" aria-labelledby=""profile-tab"">
                    <div class=""bootstrap-tab-text-grids"">
                        <div class=""bootstrap-tab-text-grids"" style=""margin:0 0 5em;"">
");
            EndContext();
#line 100 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                             foreach (var hd in hd_xl)
                            {

#line default
#line hidden
            BeginContext(7036, 308, true);
            WriteLiteral(@"                                <div class=""row table-bordered"" style=""position:relative;background-color:lightblue"">
                                    <div class=""col-md-4"" style=""text-align:left;padding:10px;"">
                                        <span>Mã đơn hàng :<span class=""text text-info""> ");
            EndContext();
            BeginContext(7345, 7, false);
#line 104 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                      Write(hd.MaHd);

#line default
#line hidden
            EndContext();
            BeginContext(7352, 81, true);
            WriteLiteral("</span></span><br />\r\n                                        <span>Đặt ngày : ");
            EndContext();
            BeginContext(7434, 10, false);
#line 105 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                      Write(hd.NgayDat);

#line default
#line hidden
            EndContext();
            BeginContext(7444, 297, true);
            WriteLiteral(@"</span>
                                    </div>
                                    <div class=""col-md-4"" style=""text-align:center;padding:10px;"">
                                        <span>Người nhận :</span><br />
                                        <span class=""text text-info"">");
            EndContext();
            BeginContext(7742, 8, false);
#line 109 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                Write(hd.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(7750, 53, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n");
            EndContext();
#line 111 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                      
                                        List<ChiTietHd> chiTietHds = db.ChiTietHd.Where(p => p.MaHd == hd.MaHd).ToList();
                                        double tongtien = 0;
                                        foreach (var ct in chiTietHds)
                                        {
                                            tongtien += Convert.ToDouble(ct.SoLuong * ct.DonGia * (1 - ct.GiamGia));
                                        }
                                    

#line default
#line hidden
            BeginContext(8343, 244, true);
            WriteLiteral("                                    <div class=\"col-md-4\" style=\"text-align:right;padding:10px;\">\r\n                                        <span>Tổng tiền :</span><br />\r\n                                        <span class=\"text text-danger\">");
            EndContext();
            BeginContext(8588, 26, false);
#line 121 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                  Write(tongtien.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(8614, 95, true);
            WriteLiteral(" đ</span>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 124 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                 foreach (var item in chiTietHds)
                                {
                                    HangHoa hh = db.HangHoa.Find(item.MaHh);
                                    double giaban = Convert.ToDouble(item.DonGia * (1 - item.GiamGia));
                                    double thanhtien = giaban * item.SoLuong;

#line default
#line hidden
            BeginContext(9073, 195, true);
            WriteLiteral("                                    <div class=\"row table-bordered\" style=\"text-align:center\">\r\n                                        <div class=\"col-md-2 text text-info\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(9268, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96fd1fae7e1c457a930c576e9ee46d1f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9278, "~/HangHoa/", 9278, 10, true);
#line 130 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
AddHtmlAttributeValue("", 9288, hh.Hinh, 9288, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9353, 111, true);
            WriteLiteral("</div>\r\n                                        <div class=\"col-md-4 text text-info\" style=\"padding-top:40px;\">");
            EndContext();
            BeginContext(9465, 8, false);
#line 131 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                  Write(hh.TenHh);

#line default
#line hidden
            EndContext();
            BeginContext(9473, 111, true);
            WriteLiteral("</div>\r\n                                        <div class=\"col-md-1 text text-info\" style=\"padding-top:40px;\">");
            EndContext();
            BeginContext(9585, 11, false);
#line 132 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                  Write(item.KichCo);

#line default
#line hidden
            EndContext();
            BeginContext(9596, 111, true);
            WriteLiteral("</div>\r\n                                        <div class=\"col-md-1 text text-info\" style=\"padding-top:40px;\">");
            EndContext();
            BeginContext(9708, 12, false);
#line 133 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                  Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(9720, 127, true);
            WriteLiteral("</div>\r\n                                        <div class=\"col-md-2 text text-info\" style=\"padding-top:40px;text-align:right\">");
            EndContext();
            BeginContext(9848, 24, false);
#line 134 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                                  Write(giaban.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(9872, 127, true);
            WriteLiteral("</div>\r\n                                        <div class=\"col-md-2 text text-info\" style=\"padding-top:40px;text-align:right\">");
            EndContext();
            BeginContext(10000, 27, false);
#line 135 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                                                                                                  Write(thanhtien.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(10027, 52, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n");
            EndContext();
#line 137 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(10114, 291, true);
            WriteLiteral(@"                                <div class=""row table-bordered"" style=""text-align:center"">
                                    <div class=""col-md-3"" style=""background-color:darkcyan"">Trạng thái đơn hàng :</div>
                                    <div class=""col-md-9 table-bordered"">
");
            EndContext();
#line 141 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                          
                                            TrangThai tt = db.TrangThai.SingleOrDefault(p => p.MaTrangThai == hd.MaTrangThai);
                                        

#line default
#line hidden
            BeginContext(10620, 127, true);
            WriteLiteral("                                        <div class=\"col-md-3 label label-danger\">\r\n                                            ");
            EndContext();
            BeginContext(10748, 15, false);
#line 145 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                                       Write(tt.TenTrangThai);

#line default
#line hidden
            EndContext();
            BeginContext(10763, 174, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <br />\r\n");
            EndContext();
#line 150 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(10968, 128, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n");
            EndContext();
#line 157 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(11110, 77, true);
            WriteLiteral("<div class=\"alert alert-danger\">Bạn cần đăng nhập để xem hóa đơn</div>\r\n");
            EndContext();
#line 162 "D:\project\asp\ASPCore_Final\ASPCore_Final\Views\MyHoaDons\Index.cshtml"
}

#line default
#line hidden
            BeginContext(11190, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591