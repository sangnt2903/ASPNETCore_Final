#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4efa59c30e122cef26aa6b1b4573e1e0992bd48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoa_Index), @"mvc.1.0.view", @"/Views/HangHoa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangHoa/Index.cshtml", typeof(AspNetCore.Views_HangHoa_Index))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4efa59c30e122cef26aa6b1b4573e1e0992bd48", @"/Views/HangHoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCore_Final.Models.HangHoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTiet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("breadcumb", async() => {
                BeginContext(114, 181, true);
                WriteLiteral("\r\n    <div class=\"breadcrumbs\">\r\n        <div class=\"container\">\r\n            <ol class=\"breadcrumb breadcrumb1 animated wow slideInLeft\" data-wow-delay=\".5s\">\r\n                <li>");
                EndContext();
                BeginContext(295, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb522ade0dba4c0b8cde0089e0d96121", async() => {
                    BeginContext(339, 75, true);
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
                BeginContext(418, 106, true);
                WriteLiteral("</li>\r\n                <li class=\"active\">Sản phẩm</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(527, 184, true);
            WriteLiteral("    <div class=\"col-md-4 products-left\">\r\n        <div class=\"categories animated wow slideInUp\" data-wow-delay=\".5s\">\r\n            <h3>Thể loại</h3>\r\n            <ul class=\"cate\">\r\n");
            EndContext();
#line 21 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                  
                    ESHOPContext db = new ESHOPContext();
                    var listNam = db.Loai.Where(p => p.GioiTinh == false).ToList();
                    int soluongSPNam = db.HangHoa.Where(p => p.MaLoaiNavigation.GioiTinh == false).ToList().Count();
                    var listNu = db.Loai.Where(p => p.GioiTinh == true).ToList();
                    int soluongSPNu = db.HangHoa.Where(p => p.MaLoaiNavigation.GioiTinh == true).ToList().Count();
                

#line default
#line hidden
            BeginContext(1211, 42, true);
            WriteLiteral("                <li>Thời trang nam<span>(");
            EndContext();
            BeginContext(1254, 12, false);
#line 28 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                     Write(soluongSPNam);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 37, true);
            WriteLiteral(")</span></li>\r\n                <ul>\r\n");
            EndContext();
#line 30 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                     foreach (var item in listNam)
                    {
                        int soluong = db.HangHoa.Where(p => p.MaLoai == item.MaLoai).ToList().Count();

#line default
#line hidden
            BeginContext(1482, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(1510, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad278a9d534f45e9aa90db61b30cfec6", async() => {
                BeginContext(1588, 12, false);
#line 33 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                                                    Write(item.TenLoai);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-loai", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                               WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loai"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-loai", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loai"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1604, 8, true);
            WriteLiteral(" <span>(");
            EndContext();
            BeginContext(1613, 7, false);
#line 33 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                                                                             Write(soluong);

#line default
#line hidden
            EndContext();
            BeginContext(1620, 15, true);
            WriteLiteral(")</span></li>\r\n");
            EndContext();
#line 34 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1658, 96, true);
            WriteLiteral("\r\n                </ul>\r\n                <li><a href=\"products.html\">Thời trang nữ</a> <span>(");
            EndContext();
            BeginContext(1755, 11, false);
#line 37 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                  Write(soluongSPNu);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 37, true);
            WriteLiteral(")</span></li>\r\n                <ul>\r\n");
            EndContext();
#line 39 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                     foreach (var item in listNu)
                    {
                        int soluong = db.HangHoa.Where(p => p.MaLoai == item.MaLoai).ToList().Count();

#line default
#line hidden
            BeginContext(1981, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(2009, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5d5d5308db4e2db159d556d206804e", async() => {
                BeginContext(2087, 12, false);
#line 42 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                                                    Write(item.TenLoai);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-loai", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                               WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loai"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-loai", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loai"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2103, 8, true);
            WriteLiteral(" <span>(");
            EndContext();
            BeginContext(2112, 7, false);
#line 42 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                                                                             Write(soluong);

#line default
#line hidden
            EndContext();
            BeginContext(2119, 15, true);
            WriteLiteral(")</span></li>\r\n");
            EndContext();
#line 43 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2157, 156, true);
            WriteLiteral("                </ul>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n<div class=\"col-md-8 products-right\">\r\n    <div class=\"products-right-grids-bottom\">\r\n");
            EndContext();
#line 50 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2362, 296, true);
            WriteLiteral(@"            <div class=""col-md-4 products-right-grids-bottom-grid"">
                <div class=""new-collections-grid1 products-right-grid1 animated wow slideInUp"" data-wow-delay="".5s"" style=""padding:10px;"">
                    <div class=""new-collections-grid1-image"">
                        ");
            EndContext();
            BeginContext(2658, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a4d5de84844d88b24854e61f01cf08", async() => {
                BeginContext(2777, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6dc0f587cadb4797b78c1ae4dcc5165d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2787, "~/HangHoa/", 2787, 10, true);
#line 55 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
AddHtmlAttributeValue("", 2797, item.Hinh, 2797, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                           WriteLiteral(item.MaHh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2844, 1538, true);
            WriteLiteral(@"
                        <div class=""new-collections-grid1-image-pos products-right-grids-pos"" style=""text-align:center"">
                            <a href=""single.html"">Xem chi tiết</a>
                        </div>
                        <div class=""new-collections-grid1-right products-right-grids-pos-right"">
                            <div class=""rating"">
                                <div class=""rating-left"">
                                    <img src=""images/2.png"" alt="" "" class=""img-responsive"">
                                </div>
                                <div class=""rating-left"">
                                    <img src=""images/2.png"" alt="" "" class=""img-responsive"">
                                </div>
                                <div class=""rating-left"">
                                    <img src=""images/2.png"" alt="" "" class=""img-responsive"">
                                </div>
                                <div class=""rating-left"">
                ");
            WriteLiteral(@"                    <img src=""images/1.png"" alt="" "" class=""img-responsive"">
                                </div>
                                <div class=""rating-left"">
                                    <img src=""images/1.png"" alt="" "" class=""img-responsive"">
                                </div>
                                <div class=""clearfix""> </div>
                            </div>
                        </div>
                    </div>
                    <h4><a href=""single.html"">");
            EndContext();
            BeginContext(4383, 10, false);
#line 80 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                         Write(item.TenHh);

#line default
#line hidden
            EndContext();
            BeginContext(4393, 34, true);
            WriteLiteral("</a></h4>\r\n                    <p>");
            EndContext();
            BeginContext(4428, 9, false);
#line 81 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                  Write(item.MoTa);

#line default
#line hidden
            EndContext();
            BeginContext(4437, 92, true);
            WriteLiteral("</p>\r\n                    <div class=\"simpleCart_shelfItem products-right-grid1-add-cart\">\r\n");
            EndContext();
#line 83 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                          
                            double dongiaban = item.DonGia * (1 - item.GiamGia);
                            double giamgia = item.GiamGia * 100;
                        

#line default
#line hidden
            BeginContext(4732, 30, true);
            WriteLiteral("                        <p><i>");
            EndContext();
            BeginContext(4763, 29, false);
#line 87 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                         Write(item.DonGia.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(4792, 32, true);
            WriteLiteral(" đ</i> <span class=\"item_price\">");
            EndContext();
            BeginContext(4825, 27, false);
#line 87 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
                                                                                       Write(dongiaban.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(4852, 135, true);
            WriteLiteral(" đ</span><a class=\"item_add\" href=\"#\">Thêm vào giỏ </a></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 91 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\HangHoa\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4998, 869, true);
            WriteLiteral(@"        <div class=""clearfix""> </div>
        <nav class=""numbering animated wow slideInRight"" data-wow-delay="".5s"">
            <ul class=""pagination paging"">
                <li>
                    <a href=""#"" aria-label=""Previous"">
                        <span aria-hidden=""true"">&laquo;</span>
                    </a>
                </li>
                <li class=""active""><a href=""#"">1<span class=""sr-only"">(current)</span></a></li>
                <li><a href=""#"">2</a></li>
                <li><a href=""#"">3</a></li>
                <li><a href=""#"">4</a></li>
                <li><a href=""#"">5</a></li>
                <li>
                    <a href=""#"" aria-label=""Next"">
                        <span aria-hidden=""true"">&raquo;</span>
                    </a>
                </li>
            </ul>
        </nav>
    </div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCore_Final.Models.HangHoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
