#pragma checksum "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30fc291cc373de3eb29f76f5dbfdfcf99e98e8772a99bc5c2597d47aca27b282"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListUsers), @"mvc.1.0.view", @"/Views/Administration/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListUsers.cshtml", typeof(AspNetCore.Views_Administration_ListUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"30fc291cc373de3eb29f76f5dbfdfcf99e98e8772a99bc5c2597d47aca27b282", @"/Views/Administration/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7fab98291b3ba798024866debd0dfe225a61d7c735cccc05911f37ac61ec729d", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
   
    ViewBag.Title = "List Users";

#line default
#line hidden
            BeginContext(79, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(86, 13, false);
#line 7 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(99, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 8 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
 if (Model.Any()) { 

#line default
#line hidden
            BeginContext(128, 290, true);
            WriteLiteral(@"    <div class=""table-responsive"">
    <table class=""table display data-table text-nowrap"" id=""myTable"">
        <thead>
            <tr>
                <th>Id</th>
                <th>User Name</th>

                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
             foreach (var user in Model)

            {

#line default
#line hidden
            BeginContext(477, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(524, 7, false);
#line 24 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
                   Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(531, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(563, 10, false);
#line 25 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
                   Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(573, 463, true);
            WriteLiteral(@"</td>


                    <td>
                        <div class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""
                               aria-expanded=""false"">
                                <span class=""flaticon-more-button-of-three-dots""></span>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"">

                                ");
            EndContext();
            BeginContext(1036, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fc291cc373de3eb29f76f5dbfdfcf99e98e8772a99bc5c2597d47aca27b2828190", async() => {
                BeginContext(1128, 126, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-cogs text-dark-pastel-green\"></i>Edit\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
                                                                                                      WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1258, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1292, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fc291cc373de3eb29f76f5dbfdfcf99e98e8772a99bc5c2597d47aca27b28211068", async() => {
                BeginContext(1387, 126, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-redo-alt text-orange-peel\"></i>Detail\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
                                                                                                         WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1517, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1551, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fc291cc373de3eb29f76f5dbfdfcf99e98e8772a99bc5c2597d47aca27b28213950", async() => {
                BeginContext(1645, 124, true);
                WriteLiteral("\r\n\r\n                                    <i class=\"fas fa-times text-orange-red\"></i>Delete\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
                                                                                                        WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1773, 120, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 50 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
}

#line default
#line hidden
            BeginContext(1896, 44, true);
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
#line 56 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Views\Administration\ListUsers.cshtml"
}

#line default
#line hidden
            BeginContext(1943, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591