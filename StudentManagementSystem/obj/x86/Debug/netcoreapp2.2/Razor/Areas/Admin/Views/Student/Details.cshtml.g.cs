#pragma checksum "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02d9c3bec89330bb2fad756264acddd2e61f4067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Student/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Student_Details))]
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
#line 1 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#line 2 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#line 3 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
using EmployeeManagement.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d9c3bec89330bb2fad756264acddd2e61f4067", @"/Areas/Admin/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf12ecaf6024c1f1c458ebe88f19de8ced96908", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-fill-lg bg-blue-dark btn-hover-yellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
  
    ViewBag.Title = "Details Student";

#line default
#line hidden
            BeginContext(106, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(149, 164, true);
            WriteLiteral("<div class=\"card height-auto\">\r\n    <div class=\"card-body\">\r\n        <div class=\"heading-layout1\">\r\n            <div class=\"item-title\">\r\n                <h3>About ");
            EndContext();
            BeginContext(314, 15, false);
#line 13 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                     Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(329, 767, true);
            WriteLiteral(@"</h3>
            </div>
            <div class=""dropdown"">
                <a class=""dropdown-toggle"" href=""#"" role=""button""
                   data-toggle=""dropdown"" aria-expanded=""false"">...</a>

                <div class=""dropdown-menu dropdown-menu-right"">
                    <a class=""dropdown-item"" href=""#""><i class=""fas fa-times text-orange-red""></i>Close</a>
                    <a class=""dropdown-item"" href=""#""><i class=""fas fa-cogs text-dark-pastel-green""></i>Edit</a>
                    <a class=""dropdown-item"" href=""#""><i class=""fas fa-redo-alt text-orange-peel""></i>Refresh</a>
                </div>
            </div>
        </div>
        <div class=""single-info-details"">
            <div class=""item-img"">
                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1096, "\"", 1118, 1);
#line 28 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
WriteAttributeValue("", 1102, Model.PhotoPath, 1102, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1119, 220, true);
            WriteLiteral(" alt=\"student\" width=\"280\" height=\"330\">\r\n            </div>\r\n            <div class=\"item-content\">\r\n                <div class=\"header-inline item-header\">\r\n                    <h3 class=\"text-dark-medium font-medium\">");
            EndContext();
            BeginContext(1340, 15, false);
#line 32 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                        Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1355, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1357, 16, false);
#line 32 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                         Write(Model.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(1373, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1375, 14, false);
#line 32 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 992, true);
            WriteLiteral(@"</h3>
                    <div class=""header-elements"">
                        <ul>
                            <li><a href=""#""><i class=""far fa-edit""></i></a></li>
                            <li><a href=""#""><i class=""fas fa-print""></i></a></li>
                            <li><a href=""#""><i class=""fas fa-download""></i></a></li>
                        </ul>
                    </div>
                </div>
                <p>
                    Aliquam erat volutpat. Curabiene natis massa sedde lacu stiquen sodale
                    word moun taiery.Aliquam erat volutpaturabiene natis massa sedde  sodale
                    word moun taiery.
                </p>
                <div class=""info-table table-responsive"">
                    <table class=""table text-nowrap"">
                        <tbody>
                            <tr>
                                <td>Name:</td>
                                <td class=""font-medium text-dark-medium"">");
            EndContext();
            BeginContext(2382, 15, false);
#line 51 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2397, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2399, 16, false);
#line 51 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                                     Write(Model.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(2415, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2417, 14, false);
#line 51 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2431, 199, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Gender:</td>\r\n                                <td class=\"font-medium text-dark-medium\">");
            EndContext();
            BeginContext(2631, 12, false);
#line 55 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(2643, 208, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>Date Of Birth:</td>\r\n                                <td class=\"font-medium text-dark-medium\">");
            EndContext();
            BeginContext(2852, 15, false);
#line 60 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(2867, 198, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Class:</td>\r\n                                <td class=\"font-medium text-dark-medium\">");
            EndContext();
            BeginContext(3066, 11, false);
#line 64 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.Class);

#line default
#line hidden
            EndContext();
            BeginContext(3077, 199, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>Roll:</td>\r\n                                <td class=\"font-medium text-dark-medium\">");
            EndContext();
            BeginContext(3277, 12, false);
#line 69 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.RollNo);

#line default
#line hidden
            EndContext();
            BeginContext(3289, 200, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Address:</td>\r\n                                <td class=\"font-medium text-dark-medium\">");
            EndContext();
            BeginContext(3490, 13, false);
#line 73 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3503, 198, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Phone:</td>\r\n                                <td class=\"font-medium text-dark-medium\">");
            EndContext();
            BeginContext(3702, 18, false);
#line 77 "F:\INTERN PROJECTS\employeemanagement_dotnetinternproject\EmployeeManagement\Areas\Admin\Views\Student\Details.cshtml"
                                                                    Write(Model.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3720, 230, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-12 form-group mg-t-8\">\r\n    ");
            EndContext();
            BeginContext(3950, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d9c3bec89330bb2fad756264acddd2e61f406714938", async() => {
                BeginContext(4047, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4180, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(4227, 188, true);
            WriteLiteral("<footer class=\"footer-wrap-layout1\">\r\n    <div class=\"copyright\">© Copyrights <a href=\"#\">Info</a> 2019. All rights reserved. Designed by <a href=\"#\">Gaurav Maharjan</a></div>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591