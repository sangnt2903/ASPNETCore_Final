#pragma checksum "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834396156005ee29755c21a1b7fb5d4b14fc5d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SendSMS_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SendSMS/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SendSMS/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SendSMS_Index))]
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
#line 1 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834396156005ee29755c21a1b7fb5d4b14fc5d76", @"/Areas/Admin/Views/SendSMS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SendSMS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPCore_Final.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/jquery-2.2.3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group-lg m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin/SendSMS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 446, true);
            WriteLiteral(@"
    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 80%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 12px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
            text-align:center;
        }
    </style>
    <div id=""body-data"">
        ");
            EndContext();
            BeginContext(591, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1e35531016e4409bc4e41957044270a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(645, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
         if (ViewBag.ListSent != null)
        {
            if (ViewBag.ListSent.Count > 0)
            {

#line default
#line hidden
            BeginContext(758, 880, true);
            WriteLiteral(@"                <span id=""infoSent"" class=""alert alert-primary"">Thông báo: Gửi tin nhắn thành công đến các số thuê bao</span>
                <script>
                    $(function () {
                        setTimeout(
                            function () {
                                $.ajax({
                                    url: ""/Admin/SendSMS"",
                                    type: ""GET"",
                                    contentType: ""application/json; charset=utf-8"",
                                    async: true,
                                    success: function (data) {
                                        $(""#infoSent"").remove();
                                    }
                                });
                            }, 3000
                        );
                    });
                </script>
");
            EndContext();
#line 49 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1686, 79, true);
            WriteLiteral("                <div class=\"alert alert-danger\">Danh sách vừa gửi trống</div>\r\n");
            EndContext();
#line 53 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1791, 159, true);
            WriteLiteral("\r\n\r\n\r\n        <div class=\"container-fluid\">\r\n            <div></div>\r\n            <h2>Gửi tin nhắn khuyến mãi, thông báo</h2>\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(1950, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78fcaccd6d004fda98d390f3896c4154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 62 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2016, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2030, 1096, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e10d983accf4476850401017d5c9ee5", async() => {
                BeginContext(2125, 994, true);
                WriteLiteral(@"
                <div class=""form-group-lg"">
                    <textarea class=""form-control"" type=""text"" name=""mess"" placeholder=""Điền vào tin nhắn""></textarea>
                    <input class="" form-control btn-primary"" type=""submit"" name=""name"" value=""Gửi tin nhắn"" />
                </div>
                <br />

                <span class=""text-danger"">Lựa chọn khách hàng muốn gửi</span>
                <div class=""form-group-lg mb-lg-2"">
                    <div class=""row m-1 form-check-inline""><input type=""radio"" class=""checkbox"" name=""checkMessToSend"" value=""friendly"" checked /> Khách hàng thân thiết</div>
                    <div class=""row m-1 form-check-inline""><input type=""radio"" class=""checkbox"" name=""checkMessToSend"" value=""normal"" /> Khách hàng thường</div>
                    <div class=""row m-1 form-check-inline""><input type=""radio"" class=""checkbox"" name=""checkMessToSend"" value=""all"" /> Tất cả khách hàng</div>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3126, 106, true);
            WriteLiteral("\r\n\r\n            <div class=\"container-fluid\">\r\n                <h2>Danh sách khách hàng sẽ được gửi</h2>\r\n");
            EndContext();
#line 80 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                 if (Model.Count > 0)
                {
                    var stt = 0;

#line default
#line hidden
            BeginContext(3324, 279, true);
            WriteLiteral(@"                    <table id=""listShow"" style=""border: 1px solid black;"">
                        <tr>
                            <th>Số thứ tự</th>
                            <th>Họ tên</th>
                            <th>Điện thoại</th>
                        </tr>
");
            EndContext();
#line 89 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                         foreach (var kh in Model)
                        {
                            stt++;

#line default
#line hidden
            BeginContext(3718, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3789, 3, false);
#line 93 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                               Write(stt);

#line default
#line hidden
            EndContext();
            BeginContext(3792, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3836, 8, false);
#line 94 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                               Write(kh.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(3844, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3888, 12, false);
#line 95 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                               Write(kh.DienThoai);

#line default
#line hidden
            EndContext();
            BeginContext(3900, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 97 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3969, 30, true);
            WriteLiteral("                    </table>\r\n");
            EndContext();
#line 99 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4059, 50, true);
            WriteLiteral("                    <span>Danh sách trống</span>\r\n");
            EndContext();
#line 103 "C:\Users\Admin\Desktop\TMDT\Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\SendSMS\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4128, 46, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        ");
            EndContext();
            BeginContext(4174, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc96b4bb72545d4ba88d36dd78ad256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4228, 1243, true);
            WriteLiteral(@"
        <script>
            $(function () {
                $('input[type=radio][name=checkMessToSend]').change(function () {

                    console.log(this.value);

                    $.ajax({
                        url: ""/Admin/SendSMS/UpdateListToSend"",
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        data: { ""typeListToChosen"": this.value },
                        async: true,
                        success: function (data) {
                            console.log(data);
                            $(""table#listShow"").html('');
                            $(""table#listShow"").append(""<tr><td>Số thứ tự</td><td>Họ tên</td><td>Điện thoại</td></tr>"");
                            for (var i = 1; i <= data.length; i++) {
                                var currentItem = data[i-1];
                                $(""table#listShow"").append(""<tr><td>"" + i + ""</td><td>"" + currentItem['taiKhoan'] + ""<");
            WriteLiteral("/td><td>\" + currentItem[\'dienThoai\'] + \"</td></tr>\");\r\n                            }\r\n                        }\r\n                    });\r\n                });\r\n            });\r\n        </script>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPCore_Final.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
