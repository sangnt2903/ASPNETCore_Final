#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6aa996b053f35e92ebb523655e761a41c42559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f6aa996b053f35e92ebb523655e761a41c42559", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTiet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 281, true);
            WriteLiteral(@"

    <div class=""banner"">
        <div class=""container"">
            <div class=""banner-info animated wow zoomIn"" data-wow-delay="".5s"">
                <h3>ESHOP</h3>
                <h4 style=""margin:auto"">Fashionista</h4>
            </div>
        </div>
    </div>
");
            EndContext();
#line 14 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
      
        ESHOPContext db = new ESHOPContext();
        List<HangHoa> hhs = db.HangHoa.ToList();
        List<HangHoa> hhnb = new List<HangHoa>();
        int demhhnb = 0;
        foreach (var item in hhs)
        {
            List<BinhLuanSp> bls = db.BinhLuanSp.Where(p => p.MaHh == item.MaHh).ToList();
            if (bls.Count > 0 && demhhnb < 6)
            {
                ++demhhnb;
                hhnb.Add(item);
            }
        }
        if (demhhnb < 6)
        {
            Random rnd = new Random();
            List<HangHoa> hhs_random = hhs.OrderBy(x => rnd.Next()).ToList();

            foreach (var hh in hhs_random)
            {
                if(!hhnb.Contains(hh) && demhhnb < 6)
                {
                    ++demhhnb;
                    hhnb.Add(hh);
                }
            }
        }
    

#line default
#line hidden
            BeginContext(1205, 211, true);
            WriteLiteral("    <div class=\"new-collections\">\r\n        <div class=\"container\">\r\n            <h3 class=\"animated wow zoomIn\" data-wow-delay=\".5s\">Sản phẩm nổi bật</h3>\r\n            <div class=\"new-collections-grids\">\r\n\r\n");
            EndContext();
#line 48 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                 foreach (var item in hhnb)
                {

#line default
#line hidden
            BeginContext(1480, 307, true);
            WriteLiteral(@"                    <div class=""col-md-4 new-collections-grid"">
                        <div class=""new-collections-grid1 new-collections-grid1-image-width animated wow slideInUp"" data-wow-delay="".5s"">
                            <div class=""new-collections-grid1-image"">
                                ");
            EndContext();
            BeginContext(1787, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d8ea1a00bf24b6096d04bfdb0c5a351", async() => {
                BeginContext(1886, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a6d7fdcb705484cbc2ef4b6101d9321", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1896, "~/HangHoa/", 1896, 10, true);
#line 53 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1906, item.Hinh, 1906, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahh", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                                                     WriteLiteral(item.MaHh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahh", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1955, 150, true);
            WriteLiteral("\r\n                                <div class=\"new-collections-grid1-image-pos new-collections-grid1-image-pos1\">\r\n                                    ");
            EndContext();
            BeginContext(2105, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42dacf7aabf41059775e64d7e439dc4", async() => {
                BeginContext(2182, 13, true);
                WriteLiteral("Xem chi tiết");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahh", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                                                         WriteLiteral(item.MaHh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahh", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2199, 1686, true);
            WriteLiteral(@"
                                </div>
                                <div class=""new-collections-grid1-right new-collections-grid1-right-rate"">
                                    <div class=""rating"">
                                        <div class=""rating-left"">
                                            <img src=""images/2.png"" alt="" "" class=""img-responsive"" />
                                        </div>
                                        <div class=""rating-left"">
                                            <img src=""images/2.png"" alt="" "" class=""img-responsive"" />
                                        </div>
                                        <div class=""rating-left"">
                                            <img src=""images/2.png"" alt="" "" class=""img-responsive"" />
                                        </div>
                                        <div class=""rating-left"">
                                            <img src=""images/2.png"" alt="" "" class=""img-responsi");
            WriteLiteral(@"ve"" />
                                        </div>
                                        <div class=""rating-left"">
                                            <img src=""images/1.png"" alt="" "" class=""img-responsive"" />
                                        </div>
                                        <div class=""clearfix""> </div>
                                    </div>
                                </div>
                                <div class=""new-one"">
                                    <p>New</p>
                                </div>
                            </div>
                            <h4><a href=""single.html"">");
            EndContext();
            BeginContext(3886, 10, false);
#line 81 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                 Write(item.TenHh);

#line default
#line hidden
            EndContext();
            BeginContext(3896, 11, true);
            WriteLiteral("</a></h4>\r\n");
            EndContext();
#line 82 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                               
                                double giaban = item.DonGia * (1 - item.GiamGia);
                            

#line default
#line hidden
            BeginContext(4054, 129, true);
            WriteLiteral("                            <div class=\"new-collections-grid1-left simpleCart_shelfItem\">\r\n                                <p><i>");
            EndContext();
            BeginContext(4184, 29, false);
#line 86 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                 Write(item.DonGia.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(4213, 32, true);
            WriteLiteral(" đ</i> <span class=\"item_price\">");
            EndContext();
            BeginContext(4246, 24, false);
#line 86 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                                                               Write(giaban.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(4270, 111, true);
            WriteLiteral(" đ</span></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 90 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4400, 50, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
