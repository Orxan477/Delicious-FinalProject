#pragma checksum "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55b734c22433b34634ec814d79ea8bc9c7fb56dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Views/Shared/_MenuPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b734c22433b34634ec814d79ea8bc9c7fb56dd", @"/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a265a8357939eaaedc63aa3d0a6938115de1f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("otherCatBut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
     foreach (var pro in Model.MenuVM.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-md-4 col-sm-6 mt-3 \">\n        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 6 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                                                  Write(pro.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n            <div class=\"img\">\n                <a href=\"#\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "55b734c22433b34634ec814d79ea8bc9c7fb56dd6926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 292, "~/assets/img/", 292, 13, true);
#nullable restore
#line 9 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
AddHtmlAttributeValue("", 305, pro.MenuImage.Image, 305, 20, false);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                </a>\n            </div>\n            <div class=\"title mt-3\">\n                <h6>");
#nullable restore
#line 13 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
               Write(pro.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            </div>\n            <div>\n\n");
#nullable restore
#line 17 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                 if (pro.Description != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-black-50\">");
#nullable restore
#line 19 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                                         Write(pro.Description.Length<=40?pro.Description:pro.Description.Substring(0,40)+"...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 20 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p></p>\n");
#nullable restore
#line 24 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-black-50\">\n");
#nullable restore
#line 26 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                     if (pro.Category.Name.ToLower().Trim() == "pizza")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" data-toggle=\"modal\" id=\"modal-pizza\" data-target=\"#pro-");
#nullable restore
#line 28 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                                                                                      Write(pro.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n                   class=\"btn btn-warning mt-2\">Secin</a>\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1147, "\"", 1162, 1);
#nullable restore
#line 30 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
WriteAttributeValue("", 1155, pro.Id, 1155, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 31 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"sum-count d-flex justify-content-between \">\n                            <div class=\"count\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55b734c22433b34634ec814d79ea8bc9c7fb56dd11885", async() => {
                WriteLiteral("\n                                    <button type=\"submit\" class=\"btn btn-warning\">Add to Cart</button>\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1639, "\"", 1654, 1);
#nullable restore
#line 38 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
WriteAttributeValue("", 1647, pro.Id, 1647, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                                                               WriteLiteral(pro.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <div class=\"sum\">\n                                <h5 style=\"color:black;\" class=\"my-2\">");
#nullable restore
#line 42 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                                                                 Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$</span></h5>\n                            </div>\n                        </div>\n");
#nullable restore
#line 45 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\n            </div>\n        </div>\n");
#nullable restore
#line 49 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
         if (pro.Category.Name.ToLower().Trim() == "pizza")
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"modal fade myModalAjax\"");
            BeginWriteAttribute("id", " id=\"", 4037, "\"", 4053, 2);
            WriteAttributeValue("", 4042, "pro-", 4042, 4, true);
#nullable restore
#line 91 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
WriteAttributeValue("", 4046, pro.Id, 4046, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"\n         aria-labelledby=\"exampleModalLabel \" aria-hidden=\"true\">\n                <div class=\"modal-dialog append-modal\" role=\"document\">\n");
            WriteLiteral("                </div>\n            </div>\n");
#nullable restore
#line 99 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 101 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Views\Shared\_MenuPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
