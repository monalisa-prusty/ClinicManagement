#pragma checksum "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a833719964aec47394a54c70eb25dc68ff7435c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ViewDoctor_Schedule), @"mvc.1.0.view", @"/Views/Doctor/ViewDoctor_Schedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a833719964aec47394a54c70eb25dc68ff7435c", @"/Views/Doctor/ViewDoctor_Schedule.cshtml")]
    public class Views_Doctor_ViewDoctor_Schedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicManagementProject.Models.DoctorSchedule>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
  
    ViewData["Title"] = "Doctor's Home";
    Layout = "~/views/shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a833719964aec47394a54c70eb25dc68ff7435c3200", async() => {
                WriteLiteral("\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ViewDoctor_Schedule</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a833719964aec47394a54c70eb25dc68ff7435c4281", async() => {
                WriteLiteral(@"
    <p>
        <a asp-action=""Create"">Create New</a>
    </p>
    <form method=""get"" name=""frmViewDoctorSchedule"">
    <table class=""table"" width=""20%"">
        <thead>
            <tr>
                
                <th>
                    ");
#nullable restore
#line 27 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
               Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
               Write(Html.DisplayNameFor(model => model.Patient_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
             if (Model != null)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Patient_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
                   Write(Html.ActionLink("Doctor Consultations", "ConsultationUpdate", new { timeSlotId = item.Timeslot_Id, patId = item.Patient_Id, docId=item.Doctor_Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <input name=\"consDocId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1496, "\"", 1519, 1);
#nullable restore
#line 52 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
WriteAttributeValue("", 1504, item.Doctor_Id, 1504, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </td>                   \r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"2\"> No Consultation slot booked for you                        \r\n                </td>\r\n               </tr>\r\n");
#nullable restore
#line 63 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ViewDoctor_Schedule.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicManagementProject.Models.DoctorSchedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
