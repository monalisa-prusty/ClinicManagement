#pragma checksum "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e523d4fd193378c1065fdf9019c1104c280c99cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ConsultationUpdate), @"mvc.1.0.view", @"/Views/Doctor/ConsultationUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e523d4fd193378c1065fdf9019c1104c280c99cb", @"/Views/Doctor/ConsultationUpdate.cshtml")]
    public class Views_Doctor_ConsultationUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.ConsultationDetail>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
  
    ViewData["Title"] = "Doctor's Home";
    Layout = "~/views/shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e523d4fd193378c1065fdf9019c1104c280c99cb3012", async() => {
                WriteLiteral("\r\n\r\n    <h4>Consultation Detail</h4>\r\n    <hr />\r\n");
#nullable restore
#line 12 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
       if (Model == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"alert-danger\">\r\n            ");
#nullable restore
#line 15 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            \r\n            <br><a");
                BeginWriteAttribute("href", " href=\"", 358, "\"", 414, 3);
                WriteAttributeValue("", 365, "ViewDoctor_Schedule?consDocId", 365, 29, true);
                WriteAttributeValue(" ", 394, "=", 395, 2, true);
#nullable restore
#line 17 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 396, ViewData["docId"], 396, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Back to Doctor\'s Schedule</a>\r\n\r\n        </section>\r\n");
#nullable restore
#line 20 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-4"">
                    <form asp-action=""ConsultationUpdate"" method=""post"">
                        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                        <input type=""hidden"" asp-for=""Consultation_Id"" name=""consId""");
                BeginWriteAttribute("value", " value=\"", 826, "\"", 856, 1);
#nullable restore
#line 27 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 834, Model.Consultation_Id, 834, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" asp-for=\"Patient_Id\" name=\"consPatId\"");
                BeginWriteAttribute("value", " value=\"", 944, "\"", 969, 1);
#nullable restore
#line 28 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 952, Model.Patient_Id, 952, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" asp-for=\"Doctor_Id\" name=\"consDocId\"");
                BeginWriteAttribute("value", " value=\"", 1056, "\"", 1080, 1);
#nullable restore
#line 29 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 1064, Model.Doctor_Id, 1064, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" asp-for=\"Consultation_Date\" name=\"consDate\"");
                BeginWriteAttribute("value", " value=\"", 1174, "\"", 1206, 1);
#nullable restore
#line 30 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 1182, Model.Consultation_Date, 1182, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" asp-for=\"Timeslot\" name=\"consTime\"");
                BeginWriteAttribute("value", " value=\"", 1291, "\"", 1314, 1);
#nullable restore
#line 31 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 1299, Model.Timeslot, 1299, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        
                        <table class=""table-light"">
                            <tr>
                                <td class=""text-dark"">
                                    <label asp-for=""Patient"" class=""control-label"">Patient Name</label>
                                </td>
                                <td>
                                    <input asp-for=""Patient"" class=""form-label"" disabled");
                BeginWriteAttribute("value", " value=\"", 1759, "\"", 1786, 1);
#nullable restore
#line 39 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 1767, Model.Patient.Name, 1767, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <label asp-for=""Doctor"" class=""control-label"">Doctor</label>
                                </td>
                                <td>
                                    <input asp-for=""Doctor"" class=""form-label"" disabled");
                BeginWriteAttribute("value", " value=\"", 2202, "\"", 2228, 1);
#nullable restore
#line 48 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 2210, Model.Doctor.Name, 2210, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label asp-for=""Date"" class=""control-label"">Consultation Date</label>
                                </td>
                                <td>
                                    <input asp-for=""Consultation_Date"" class=""form-label"" type=""date""");
                BeginWriteAttribute("value", " value=\"", 2665, "\"", 2697, 1);
#nullable restore
#line 56 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 2673, Model.Consultation_Date, 2673, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <span asp-validation-for=""Consultation_Date"" class=""text-danger""></span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label asp-for=""Date"" class=""control-label"">Time Slot</label>
                                </td>
                                <td>
                                    <input asp-for=""Timeslot"" class=""form-control"" disabled");
                BeginWriteAttribute("value", " value=\"", 3226, "\"", 3249, 1);
#nullable restore
#line 65 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 3234, Model.Timeslot, 3234, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <span asp-validation-for=""Timeslot"" class=""text-danger""></span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label asp-for=""Consultation_Remarks"" class=""control-label"">Consultation Remark</label>
                                </td>
                                <td>
                                    <textarea asp-for=""Consultation_Remarks"" name=""consRemarks"" class=""form-control-lg"">");
#nullable restore
#line 74 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                                                                                                                   Write(Model.Consultation_Remarks);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                                    <span asp-validation-for=""Consultation_Remarks"" class=""text-danger""></span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label asp-for=""Consultation_Status"" class=""control-label"">Consultation Status</label>
                                </td>
                                <td>
                                    <select asp-for=""Consultation_Status"" name=""consStatus"" class=""form-select"">
                                        <option");
                BeginWriteAttribute("value", " value=\"", 4485, "\"", 4519, 1);
#nullable restore
#line 84 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 4493, Model.Consultation_Status, 4493, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 84 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                                                                              Write(Model.Consultation_Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</option>
                                        <option value=""Pending Payment"">Pending Payment</option>
                                        <option value=""Closed"">Closed</option>
                                    </select>
                                    <span asp-validation-for=""Consultation_Status"" class=""text-danger""></span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label asp-for=""Bill"" class=""control-label"">Bill Amount</label>
                                </td>
                                <td>
                                    <input asp-for=""Bill"" class=""form-control"" name=""consBill""");
                BeginWriteAttribute("value", " value=\"", 5313, "\"", 5332, 1);
#nullable restore
#line 96 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
WriteAttributeValue("", 5321, Model.Bill, 5321, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <span asp-validation-for=""Bill"" class=""text-danger""></span>
                                </td>
                            </tr>
                        </table>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                            ");
#nullable restore
#line 103 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                       Write(Html.ActionLink("Back to Schedule ", "ViewDoctor_Schedule", new { consDocId = Model.Doctor.Doctor_Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        <hr />\r\n        <Section class=\"alert-info\">");
#nullable restore
#line 109 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                               Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</Section>\r\n        <hr />\r\n");
#nullable restore
#line 111 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"

            var patientHistory = ViewBag.ConsHistory;
            int patID = @Model.Patient_Id;
            string docName = "";

        

#line default
#line hidden
#nullable disable
                WriteLiteral("<table class=\"table table-light\" width=\"80%\">\r\n            <thead class=\"thead-dark\"><b>Consultation History for ");
#nullable restore
#line 117 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                                                             Write(Model.Patient.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></thead>
            <tr>
                <td class=""thead-light""><b>Consultation Date</b></td>
                <td class=""thead-light""><b>Doctor Name</b></td>
                <td class=""thead-light""><b>Consultation Detail</b></td>
            </tr>

");
#nullable restore
#line 124 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
             for (int i = 0; i < patientHistory.Count; i++)
            {
                if (patientHistory[i].Patient_Id == patID)
                {
                    if (@patientHistory[i].Doctor == null)
                        docName = "Doctor not mentioned";
                    else
                        docName = @patientHistory[i].Doctor.Name;

                        

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n                            <td>");
#nullable restore
#line 134 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                           Write(patientHistory[i].Consultation_Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 135 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                           Write(docName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 136 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                           Write(patientHistory[i].Consultation_Remarks);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 138 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
                }

            }            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n");
#nullable restore
#line 143 "C:\CollaberaTraining\CollaberaTraining\FinalProject\ClinicManagementProject-main\Views\Doctor\ConsultationUpdate.cshtml"
        }
 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.ConsultationDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
