#pragma checksum "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a767632f6b98c73ac98411931eb79f03eacc0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoaDons_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoaDons/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HoaDons/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_HoaDons_Index))]
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
#line 1 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 3 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a767632f6b98c73ac98411931eb79f03eacc0a", @"/Areas/Admin/Views/HoaDons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoaDons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(249, 109, true);
            WriteLiteral("\r\n\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách nhân viên</h4>\r\n    ");
            EndContext();
            BeginContext(358, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6d19a9dd3074b02aefc562262b7ba0c", async() => {
                BeginContext(397, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 478, "\"", 535, 1);
#line 15 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
WriteAttributeValue("", 502, Model.RouteValue["searchString"], 502, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(536, 169, true);
                WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-info\">\r\n            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Search\r\n        </button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(712, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(731, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aedff795c4e34449bf64abe95d8ea8fa", async() => {
                BeginContext(778, 7, true);
                WriteLiteral("Tạo mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(789, 130, true);
            WriteLiteral("\r\n    </p>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(920, 40, false);
#line 28 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaHd));

#line default
#line hidden
            EndContext();
            BeginContext(960, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1040, 43, false);
#line 31 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1163, 41, false);
#line 34 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1284, 42, false);
#line 37 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1406, 48, false);
#line 40 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SdtNguoinhan));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1534, 42, false);
#line 43 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1656, 48, false);
#line 46 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1784, 40, false);
#line 49 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1904, 50, false);
#line 52 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaKhNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(2034, 57, false);
#line 55 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaTrangThaiNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 61 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2254, 84, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2339, 39, false);
#line 65 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaHd));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2470, 42, false);
#line 68 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2604, 40, false);
#line 71 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(2644, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2736, 41, false);
#line 74 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2777, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2869, 47, false);
#line 77 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SdtNguoinhan));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(3008, 41, false);
#line 80 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(3049, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(3141, 47, false);
#line 83 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(3188, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(3280, 39, false);
#line 86 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(3411, 55, false);
#line 89 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaKhNavigation.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3466, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(3558, 69, false);
#line 92 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaTrangThaiNavigation.TenTrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(3627, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3706, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b868c65948546beb5788253e8ed9c82", async() => {
                BeginContext(3777, 3, true);
                WriteLiteral("Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                                               WriteLiteral(item.MaHd);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3784, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3812, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "859f0ddb2e40436d99e38011224c6eae", async() => {
                BeginContext(3886, 12, true);
                WriteLiteral("Xem chi tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                                                  WriteLiteral(item.MaHd);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3902, 451, true);
            WriteLiteral(@" |

                        <button type=""button"" class=""btn btn-primary"" onclick=""return _delete()"" id=""btnDelete"">Xóa</button>
                        <script>
                            function _delete() {
                                var cf = confirm('Bạn có muốn xoá hóa đơn này?');
                                if (cf) {
                                    $.ajax({
                                        url: '/api/HoaDons/' + ");
            EndContext();
            BeginContext(4354, 9, false);
#line 104 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
                                                          Write(item.MaHd);

#line default
#line hidden
            EndContext();
            BeginContext(4363, 842, true);
            WriteLiteral(@",
                                        type: ""Delete"",
                                        contentType: ""application/json; charset=utf-8"",
                                        dataType: ""json"",
                                        async: true,
                                        success: function (result) {
                                            alert(""Xoá hóa đơn thành công"");
                                        },
                                        error: function (errormessage) {
                                            alert(errormessage.responseText);
                                        }
                                    });
                                }
                            }
                        </script>
                    </td>
                </tr>
");
            EndContext();
#line 121 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5220, 101, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <nav class=\"navbar-default justify-content-center\">\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(5322, 135, false);
#line 127 "D:\CongNgheWeb\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoaDons\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(5457, 26, true);
            WriteLiteral("\r\n\r\n\r\n    </nav>\r\n\r\n</div>");
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
