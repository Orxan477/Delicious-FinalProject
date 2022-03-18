#pragma checksum "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7577531eeb4077171160be915a3a6be7095438ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_MyOrder), @"mvc.1.0.view", @"/Views/Menu/MyOrder.cshtml")]
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
#nullable restore
#line 1 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Footer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7577531eeb4077171160be915a3a6be7095438ea", @"/Views/Menu/MyOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a265a8357939eaaedc63aa3d0a6938115de1f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_MyOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/otherPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/menu.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
  
    ViewData["Title"] = "Index";
    int count = ViewBag.TakeCount;
    int page = Model.Paginate.PageCount;
    int productNum = ((Model.Paginate.CurrentPage - 1) * count) + 1;
    int previous = Model.Paginate.CurrentPage - 1;
    int next = Model.Paginate.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 grid-margin stretch-card\">\r\n");
            WriteLiteral(@"                <div class=""card-body"" style=""margin-top:120px;"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>No</th>
                                    <th>FullName</th>
                                    <th>Count</th>
                                    <th>Order Date</th>
                                    <th>Status</th>
                                    <th>Order Total</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 29 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                 foreach (var item in Model.Paginate.Items)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 32 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                   Write(productNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 33 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 35 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                         if (item.Status=="pending")
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <td style=\"text-align:center;\" class=\"text-danger\">");
#nullable restore
#line 38 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                         Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 39 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                        if (item.Status=="preparing")
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <td style=\"text-align:center;\" class=\"text-primary\">");
#nullable restore
#line 42 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                          Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 43 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                        if (item.Status=="way")
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <td style=\"text-align:center;\" class=\"text-warning\">");
#nullable restore
#line 46 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                          Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 47 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                        if (item.Status=="delivired")
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <td style=\"text-align:center;\" class=\"text-success\">");
#nullable restore
#line 50 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                          Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 51 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 52 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 54 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                    productNum++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 58 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                         if (Model.Paginate.PageCount!=1 && Model.Paginate.PageCount!=0)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           <div class=""col-lg-12 grid-margin stretch-card justify-content-center mt-4 mb-0"">
                                <nav aria-label=""..."">
                                    <ul class=""pagination pagination-md"">
                                        <li");
            BeginWriteAttribute("class", " class=\"", 3266, "\"", 3327, 2);
            WriteAttributeValue("", 3274, "page-item", 3274, 9, true);
#nullable restore
#line 63 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
WriteAttributeValue(" ", 3283, Model.Paginate.CurrentPage<3?"d-none":"", 3284, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea14640", async() => {
                WriteLiteral("First");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                        <li");
            BeginWriteAttribute("class", " class=\"", 3535, "\"", 3600, 2);
            WriteAttributeValue("", 3543, "page-item", 3543, 9, true);
#nullable restore
#line 66 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
WriteAttributeValue(" ", 3552, Model.Paginate.CurrentPage==1   ?"d-none":"", 3553, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea17015", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                        WriteLiteral(previous);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n\r\n");
#nullable restore
#line 70 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                         if (Model.Paginate.CurrentPage >= 2 && Model.Paginate.CurrentPage < Model.Paginate.PageCount)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                             for (int i = Model.Paginate.CurrentPage - 1; i <= Model.Paginate.CurrentPage + 1; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li");
            BeginWriteAttribute("class", " class=\"", 4188, "\"", 4252, 2);
            WriteAttributeValue("", 4196, "page-item", 4196, 9, true);
#nullable restore
#line 74 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
WriteAttributeValue(" ", 4205, Model.Paginate.CurrentPage==i?"disabled":"", 4206, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea20741", async() => {
#nullable restore
#line 75 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                                WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </li>\r\n");
#nullable restore
#line 77 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 4564, "\"", 4649, 2);
            WriteAttributeValue("", 4572, "page-item", 4572, 9, true);
#nullable restore
#line 79 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
WriteAttributeValue(" ", 4581, Model.Paginate.CurrentPage==Model.Paginate.PageCount?"d-none":"", 4582, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea24456", async() => {
                WriteLiteral("Next >");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                        WriteLiteral(next);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                        <li");
            BeginWriteAttribute("class", " class=\"", 4862, "\"", 4947, 2);
            WriteAttributeValue("", 4870, "page-item", 4870, 9, true);
#nullable restore
#line 82 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
WriteAttributeValue(" ", 4879, Model.Paginate.CurrentPage==Model.Paginate.PageCount?"d-none":"", 4880, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea27397", async() => {
                WriteLiteral("Last");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                                                                                        WriteLiteral(Model.Paginate.PageCount);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </nav>\r\n                            </div>  \n");
#nullable restore
#line 88 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Menu\MyOrder.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea30333", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577531eeb4077171160be915a3a6be7095438ea31429", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
