#pragma checksum "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8278e5ee6759de53ef36b43c9f99856621443af32333b2a6881f02730ce0b053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Index___Copy___Copy), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Index - Copy - Copy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Student/Index - Copy - Copy.cshtml", typeof(AspNetCore.Areas_Admin_Views_Student_Index___Copy___Copy))]
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
#line 1 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 2 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.ViewModels;

#line default
#line hidden
#line 3 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models;

#line default
#line hidden
#line 5 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8278e5ee6759de53ef36b43c9f99856621443af32333b2a6881f02730ce0b053", @"/Areas/Admin/Views/Student/Index - Copy - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"19e0342fe45c0e2a090b16885c7af258593ffcc7e164ac41daa10cfe3113117b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Index___Copy___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
  
    ViewBag.Title = "Student List";
    int sn = 0;
    //var photoPath = "";


#line default
#line hidden
            BeginContext(127, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n<div class=\"text-right\">\r\n\r\n    <h1 class=\"d-inline\">");
            EndContext();
            BeginContext(358, 13, false);
#line 23 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
                    Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(371, 85, true);
            WriteLiteral("</h1>\r\n\r\n\r\n    <div class=\"float-right text-right col-sm-6 d-inline p-2\">\r\n\r\n        ");
            EndContext();
            BeginContext(456, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8278e5ee6759de53ef36b43c9f99856621443af32333b2a6881f02730ce0b0537297", async() => {
                BeginContext(528, 6, true);
                WriteLiteral("Create");
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
            BeginContext(538, 195, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<table class=\"table table-bordered table-responsive table-hover\" id=\"myTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>S.N.</th>\r\n            <th>RollNo</th>\r\n");
            EndContext();
            BeginContext(765, 293, true);
            WriteLiteral(@"            <th>Name</th>
            <th>Address</th>
            <th>Class</th>
            <th>BloodGroup</th>
            <th>MobileNumber</th>
            <th>Birthdate</th>
            <th>Gender</th>
            <th>Action</th>

        </tr>
    </thead>



    <tbody>
");
            EndContext();
#line 57 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
         foreach (var student in Model)
        {

            //photoPath = "~/images/" + (student.PhotoPath ?? "employee_pic.jpg");

            sn = sn + 1;

#line default
#line hidden
            BeginContext(1224, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1263, 2, false);
#line 64 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(sn);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1293, 14, false);
#line 65 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.RollNo);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1456, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1477, 17, false);
#line 69 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1496, 18, false);
#line 69 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
                                  Write(student.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1516, 16, false);
#line 69 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
                                                      Write(student.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1560, 15, false);
#line 70 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1575, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1603, 13, false);
#line 71 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.Class);

#line default
#line hidden
            EndContext();
            BeginContext(1616, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1644, 18, false);
#line 72 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.BloodGroup);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1690, 20, false);
#line 73 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1710, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1738, 45, false);
#line 74 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.BirthDate.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1811, 14, false);
#line 75 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
               Write(student.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1825, 75, true);
            WriteLiteral("</td>\r\n\r\n\r\n                <td class=\"p-0 m-0 row\">\r\n\r\n                    ");
            EndContext();
            BeginContext(1900, 637, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8278e5ee6759de53ef36b43c9f99856621443af32333b2a6881f02730ce0b05314541", async() => {
                BeginContext(1990, 543, true);
                WriteLiteral(@"

                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pen-fill"" viewBox=""0 0 16 16"">
                            <path d=""m13.498.795.149-.149a1.207 1.207 0 1 1 1.707 1.708l-.149.148a1.5 1.5 0 0 1-.059 2.059L4.854 14.854a.5.5 0 0 1-.233.131l-4 1a.5.5 0 0 1-.606-.606l1-4a.5.5 0 0 1 .131-.232l9.642-9.642a.5.5 0 0 0-.642.056L6.854 4.854a.5.5 0 1 1-.708-.708L9.44.854A1.5 1.5 0 0 1 11.5.796a1.5 1.5 0 0 1 1.998-.001z"" />
                        </svg>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
                                                                    WriteLiteral(student.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2537, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2559, 779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8278e5ee6759de53ef36b43c9f99856621443af32333b2a6881f02730ce0b05317818", async() => {
                BeginContext(2651, 683, true);
                WriteLiteral(@"
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash3-fill"" viewBox=""0 0 16 16"">
                            <path d=""M11 1.5v1h3.5a.5.5 0 0 1 0 1h-.538l-.853 10.66A2 2 0 0 1 11.115 16h-6.23a2 2 0 0 1-1.994-1.84L2.038 3.5H1.5a.5.5 0 0 1 0-1H5v-1A1.5 1.5 0 0 1 6.5 0h3A1.5 1.5 0 0 1 11 1.5Zm-5 0v1h4v-1a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 0-.5.5ZM4.5 5.029l.5 8.5a.5.5 0 1 0 .998-.06l-.5-8.5a.5.5 0 1 0-.998.06Zm6.53-.528a.5.5 0 0 0-.528.47l-.5 8.5a.5.5 0 0 0 .998.058l.5-8.5a.5.5 0 0 0-.47-.528ZM8 4.5a.5.5 0 0 0-.5.5v8.5a.5.5 0 0 0 1 0V5a.5.5 0 0 0-.5-.5Z"" />
                        </svg>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
                                                                      WriteLiteral(student.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3338, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3360, 700, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8278e5ee6759de53ef36b43c9f99856621443af32333b2a6881f02730ce0b05321237", async() => {
                BeginContext(3453, 603, true);
                WriteLiteral(@"
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-info-circle"" viewBox=""0 0 16 16"">
                            <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                            <path d=""m8.93 6.588-2.29.287-.082.38.45.083c.294.07.352.176.288.469l-.738 3.468c-.194.897.105 1.319.808 1.319.545 0 1.178-.252 1.465-.598l.088-.416c-.2.176-.492.246-.686.246-.275 0-.375-.193-.304-.533L8.93 6.588zM9 4.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"" />
                        </svg>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"
                                                                       WriteLiteral(student.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4060, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 99 "G:\Studentmgmt\TutorFinderNew\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy - Copy.cshtml"


        }

#line default
#line hidden
            BeginContext(4119, 138, true);
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n\r\n<script>\r\n\r\n    $(document).ready(function () {\r\n\r\n        $(\"#myTable\").DataTable();\r\n    })\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
