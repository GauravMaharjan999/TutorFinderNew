#pragma checksum "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Account\Login - Copy.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "77ef3ace2415e1d1b8a3c1e481ffeee9dae23b1d0d00d40448725d6b69d19eb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login___Copy), @"mvc.1.0.view", @"/Views/Account/Login - Copy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login - Copy.cshtml", typeof(AspNetCore.Views_Account_Login___Copy))]
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
#line 1 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 2 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagement.ViewModels;

#line default
#line hidden
#line 3 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\_ViewImports.cshtml"
using Modellayer.Models;

#line default
#line hidden
#line 5 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\_ViewImports.cshtml"
using Modellayer.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"77ef3ace2415e1d1b8a3c1e481ffeee9dae23b1d0d00d40448725d6b69d19eb2", @"/Views/Account/Login - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7fab98291b3ba798024866debd0dfe225a61d7c735cccc05911f37ac61ec729d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Account\Login - Copy.cshtml"
  
    ViewBag.Title = "User Login";

#line default
#line hidden
            BeginContext(68, 6, false);
#line 6 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Account\Login - Copy.cshtml"
Write(Layout);

#line default
#line hidden
            EndContext();
            BeginContext(74, 11, true);
            WriteLiteral("= null;\r\n\r\n");
            EndContext();
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1365, 353, true);
            WriteLiteral(@"



<!-- Preloader Start Here -->
<div id=""preloader""></div>
<!-- Preloader End Here -->
<!-- Login Page Start Here -->
<div class=""login-page-wrap"">
    <div class=""login-page-content"">
        <div class=""login-box"">
            <div class=""item-logo"">
                <img src=""img/logo2.png"" alt=""logo"">
            </div>
            ");
            EndContext();
            BeginContext(1718, 1163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ef3ace2415e1d1b8a3c1e481ffeee9dae23b1d0d00d40448725d6b69d19eb25807", async() => {
                BeginContext(1763, 1111, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label>Username</label>
                    <input type=""text"" placeholder=""Enter usrename"" class=""form-control"">
                    <i class=""far fa-envelope""></i>
                </div>
                <div class=""form-group"">
                    <label>Password</label>
                    <input type=""text"" placeholder=""Enter password"" class=""form-control"">
                    <i class=""fas fa-lock""></i>
                </div>
                <div class=""form-group d-flex align-items-center justify-content-between"">
                    <div class=""form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""remember-me"">
                        <label for=""remember-me"" class=""form-check-label"">Remember Me</label>
                    </div>
                    <a href=""#"" class=""forgot-btn"">Forgot Password?</a>
                </div>
                <div class=""form-group"">
                    <butt");
                WriteLiteral("on type=\"submit\" class=\"login-btn\">Login</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(2881, 650, true);
            WriteLiteral(@"
            <div class=""login-social"">
                <p>or sign in with</p>
                <ul>
                    <li><a href=""#"" class=""bg-fb""><i class=""fab fa-facebook-f""></i></a></li>
                    <li><a href=""#"" class=""bg-twitter""><i class=""fab fa-twitter""></i></a></li>
                    <li><a href=""#"" class=""bg-gplus""><i class=""fab fa-google-plus-g""></i></a></li>
                    <li><a href=""#"" class=""bg-git""><i class=""fab fa-github""></i></a></li>
                </ul>
            </div>
        </div>
        <div class=""sign-up"">Don't have an account ? <a href=""#"">Signup now!</a></div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591