#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e76fd734b6aeadff67f6a279c5bc4493339de2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCaps_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCaps/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhaCungCaps/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhaCungCaps_Index))]
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
#line 1 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 3 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e76fd734b6aeadff67f6a279c5bc4493339de2", @"/Areas/Admin/Views/NhaCungCaps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhaCungCaps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.NhaCungCap>>
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
#line 5 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(253, 78, true);
            WriteLiteral("\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h2>Danh sách nhà cung cấp</h2>\r\n    ");
            EndContext();
            BeginContext(331, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa3bd9ad6eda4e8ba5fe62b1e25e3cd7", async() => {
                BeginContext(370, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 451, "\"", 508, 1);
#line 14 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
WriteAttributeValue("", 475, Model.RouteValue["searchString"], 475, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(509, 169, true);
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
            BeginContext(685, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(704, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "affe2b21fde64f4c9653a66f447f805f", async() => {
                BeginContext(751, 7, true);
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
            BeginContext(762, 142, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(905, 45, false);
#line 26 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TenCongTy));

#line default
#line hidden
            EndContext();
            BeginContext(950, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1030, 41, false);
#line 29 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1151, 45, false);
#line 32 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1276, 42, false);
#line 35 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1398, 40, false);
#line 38 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1601, 84, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1686, 44, false);
#line 48 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenCongTy));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1822, 40, false);
#line 51 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1954, 44, false);
#line 54 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2090, 41, false);
#line 57 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2223, 39, false);
#line 60 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2353, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28f7f8711a4f45f8a0cdc4b292a3fc90", async() => {
                BeginContext(2425, 3, true);
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
#line 63 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                                               WriteLiteral(item.MaNcc);

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
            BeginContext(2432, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2460, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9714b29863364e988313869532f5b391", async() => {
                BeginContext(2535, 12, true);
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
#line 64 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                                                  WriteLiteral(item.MaNcc);

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
            BeginContext(2551, 460, true);
            WriteLiteral(@" |

                        <button type=""button"" class=""btn btn-primary"" onclick=""return _delete()"" id=""btnDelete"">Xóa</button>
                        <script>
                            function _delete() {
                                var cf = confirm('Bạn có muốn xoá nhà cung cấp này?');
                                if (cf) {
                                    $.ajax({
                                        url: '/api/NhaCungCaps/' + ");
            EndContext();
            BeginContext(3012, 10, false);
#line 72 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
                                                              Write(item.MaNcc);

#line default
#line hidden
            EndContext();
            BeginContext(3022, 847, true);
            WriteLiteral(@",
                                        type: ""Delete"",
                                        contentType: ""application/json; charset=utf-8"",
                                        dataType: ""json"",
                                        async: true,
                                        success: function (result) {
                                            alert(""Xoá nhà cung cấp thành công"");
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
#line 89 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3884, 101, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <nav class=\"navbar-default justify-content-center\">\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(3986, 135, false);
#line 95 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(4121, 24, true);
            WriteLiteral("\r\n\r\n\r\n    </nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.NhaCungCap>> Html { get; private set; }
    }
}
#pragma warning restore 1591
