#pragma checksum "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\Shared\Components\Navbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4139ed9389c2306a48d849bf5dbfbb29f7b0bd5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Shared_Components_Navbar_Default), @"mvc.1.0.view", @"/Areas/admin/Views/Shared/Components/Navbar/Default.cshtml")]
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
#line 1 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Footer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Team;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Position;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4139ed9389c2306a48d849bf5dbfbb29f7b0bd5a", @"/Areas/admin/Views/Shared/Components/Navbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843cc2b1ebf8646f60c016669c712de3e71f431c", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Shared_Components_Navbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/images/logo-mini.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar p-0 fixed-top d-flex flex-row\">\r\n          <div class=\"navbar-brand-wrapper d-flex d-lg-none align-items-center justify-content-center\">\r\n            <a class=\"navbar-brand brand-logo-mini\" href=\"index.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4139ed9389c2306a48d849bf5dbfbb29f7b0bd5a5654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
          </div>
          <div class=""navbar-menu-wrapper flex-grow d-flex align-items-stretch"">
            <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
              <span class=""mdi mdi-menu""></span>
            </button>
            <ul class=""navbar-nav navbar-nav-right"">
              <li class=""nav-item dropdown d-none d-lg-block"">
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""createbuttonDropdown"">
                  <h6 class=""p-3 mb-0"">Projects</h6>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-file-outline text-primary""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content");
            WriteLiteral(@""">
                      <p class=""preview-subject ellipsis mb-1"">Software Development</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-web text-info""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">UI Development</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-layers text-danger""></i>
                   ");
            WriteLiteral(@"   </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">Software Testing</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <p class=""p-3 mb-0 text-center"">See all projects</p>
                </div>
              </li>
              <li class=""nav-item dropdown"">
                <a class=""nav-link"" id=""profileDropdown"" href=""#"" data-toggle=""dropdown"">
                  <div class=""navbar-profile"">
                    <p class=""mb-0 d-none d-sm-block navbar-profile-name"">Orkhan Ganbarov</p>
                    <i class=""mdi mdi-menu-down d-none d-sm-block""></i>
                  </div>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""profileDropdown"">
                  <h6 class=""p-3 mb-0"">Profile</h6>
                  <div class=""dropdow");
            WriteLiteral(@"n-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-settings text-success""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject mb-1"">Settings</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-logout text-danger""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject mb-1"">Log out</p>
                    </div>");
            WriteLiteral(@"
                  </a>
                  <div class=""dropdown-divider""></div>
                  <p class=""p-3 mb-0 text-center"">Advanced settings</p>
                </div>
              </li>
            </ul>
            <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
              <span class=""mdi mdi-format-line-spacing""></span>
            </button>
          </div>
        </nav>");
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
