#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestTech_DataTable), @"mvc.1.0.view", @"/Views/TestTech/DataTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestTech/DataTable.cshtml", typeof(AspNetCore.Views_TestTech_DataTable))]
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
#line 1 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\_ViewImports.cshtml"
using HeadCountSizingPRD;

#line default
#line hidden
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\_ViewImports.cshtml"
using HeadCountSizingPRD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e27", @"/Views/TestTech/DataTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19231971b9cfd504b87d99906ea6f0243cbc0247", @"/Views/_ViewImports.cshtml")]
    public class Views_TestTech_DataTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VStation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-equipment-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Planned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Unplanned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
  
    ViewData["Title"] = "GetAllColumnName";
    var months = new List<string> { "Sep", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
    //var months = new List<int> { 1, 2, 3,4, 5, 6, 7, 8, 9, 10, 11, 12 };
    var downtimeDetail = ViewData["downtimeDetail"] as IEnumerable<SharedObjects.ValueObjects.VDowntime>;

#line default
#line hidden
            BeginContext(408, 379, true);
            WriteLiteral(@"
<div class=""caption col-md-12"">
    <span class=""caption-subject font-green-sharp bold uppercase"">
        Equipment Data Entry
    </span>
    <span class=""caption-subject font-green-sharp bold uppercase"">
        <a class=""btn btn-success"" id=""btn-add-equipemnt-stationOrTester"" data-toggle=""modal"" style=""visibility:hidden"">Add Station Data</a>
    </span>
</div>

");
            EndContext();
            BeginContext(787, 1930, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e275935", async() => {
                BeginContext(817, 149, true);
                WriteLiteral("\r\n    <table id=\"tbl-equipment\" class=\"table table-bordered table-hover table-striped\">\r\n        <thead>\r\n            <tr class=\"text-center bold\">\r\n");
                EndContext();
                BeginContext(1067, 305, true);
                WriteLiteral(@"                <td style=""width:50px"">
                    Month
                </td>
                <td class=""columnwidth""><input id=""txt-add-equipment-stationOrTester"" onchange=""fncOnchangeStationOrTester()"" class=""form-control uppercase"" name=""addStationOrTester"" style=""height:30px"" /></td>

");
                EndContext();
#line 30 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(1437, 23, true);
                WriteLiteral("                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1460, "\"", 1486, 1);
#line 32 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 1465, item.stationOrTester, 1465, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1487, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(1509, 20, false);
#line 32 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                  Write(item.stationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(1529, 12, true);
                WriteLiteral(" (Qty) </td>");
                EndContext();
#line 32 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                                                        }

#line default
#line hidden
                BeginContext(1544, 113, true);
                WriteLiteral("                <td class=\"columnwidth\">Modification</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 37 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
             for (int CustId = 1; CustId <= months.Count; CustId++)
            {

#line default
#line hidden
                BeginContext(1741, 42, true);
                WriteLiteral("                <tr class=\"text-center\">\r\n");
                EndContext();
                BeginContext(1877, 36, true);
                WriteLiteral("                    <td data-month=\"");
                EndContext();
                BeginContext(1914, 6, false);
#line 43 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                               Write(CustId);

#line default
#line hidden
                EndContext();
                BeginContext(1920, 2, true);
                WriteLiteral("\">");
                EndContext();
                BeginContext(1923, 18, false);
#line 43 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                        Write(months[CustId - 1]);

#line default
#line hidden
                EndContext();
                BeginContext(1941, 83, true);
                WriteLiteral("</td>\r\n                    <td class=\"columnwidth\">\r\n                        <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2024, "\"", 2054, 2);
                WriteAttributeValue("", 2029, "txt-add-equipment-", 2029, 18, true);
#line 45 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 2047, CustId, 2047, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2055, 87, true);
                WriteLiteral(" type=\"number\" class=\"form-control\" style=\"height:30px\" />\r\n                    </td>\r\n");
                EndContext();
#line 47 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                     foreach (var item1 in Model)
                    {

#line default
#line hidden
                BeginContext(2216, 27, true);
                WriteLiteral("                        <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2243, "\"", 2278, 3);
#line 49 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 2248, CustId, 2248, 7, false);

#line default
#line hidden
                WriteAttributeValue("", 2255, "-", 2255, 1, true);
#line 49 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 2256, item1.stationOrTester, 2256, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2279, 19, true);
                WriteLiteral(" data-stationname=\"");
                EndContext();
                BeginContext(2299, 21, false);
#line 49 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                             Write(item1.stationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(2320, 37, true);
                WriteLiteral("\" ondblclick=\"addInput(this)\"></td>\r\n");
                EndContext();
#line 50 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                    }

#line default
#line hidden
                BeginContext(2380, 151, true);
                WriteLiteral("                    <td class=\"text-center\">\r\n                        <a id=\"btn-editdebugdata\" class=\"btn default btn-xs purple update\" data-monthId=\"");
                EndContext();
                BeginContext(2532, 6, false);
#line 52 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                                                    Write(CustId);

#line default
#line hidden
                EndContext();
                BeginContext(2538, 125, true);
                WriteLiteral("\" title=\"Edit\"> <span class=\"glyphicon glyphicon-floppy-save\"></span></a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 55 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
            }

#line default
#line hidden
                BeginContext(2678, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2717, 152, true);
            WriteLiteral("\r\n\r\n<div class=\"caption col-md-12\">\r\n    <span class=\"caption-subject font-green-sharp bold uppercase\">\r\n        Downtime Entry\r\n    </span>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2869, 2695, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e2715372", async() => {
                BeginContext(2875, 334, true);
                WriteLiteral(@"
    <table id=""tbl-downtime"" class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr class=""text-center bold"">
                <td style=""width:50px"">
                    Type
                </td>
                <td style=""width:50px"">
                    Activities
                </td>
");
                EndContext();
#line 76 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(3274, 23, true);
                WriteLiteral("                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3297, "\"", 3323, 1);
#line 78 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 3302, item.stationOrTester, 3302, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3324, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(3346, 20, false);
#line 78 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                  Write(item.stationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(3366, 16, true);
                WriteLiteral(" (mins/day)</td>");
                EndContext();
#line 78 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                                                            }

#line default
#line hidden
                BeginContext(3385, 357, true);
                WriteLiteral(@"                <td class=""columnwidth"">Modification</td>
            </tr>
        </thead>
        <tbody >
            <tr class=""text-center"">
                <td class=""columnwidth"">
                    <select class=""form-control"" id=""txt-dowtimetype"" style=""color:mediumvioletred"" onchange=""fncOnchangeDowntimeType()"">
                        ");
                EndContext();
                BeginContext(3742, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e2718221", async() => {
                    BeginContext(3760, 31, true);
                    WriteLiteral("--Please Select downtime type--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3800, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3826, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e2719737", async() => {
                    BeginContext(3850, 7, true);
                    WriteLiteral("Planned");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3866, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3892, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e2721228", async() => {
                    BeginContext(3918, 9, true);
                    WriteLiteral("Unplanned");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3936, 270, true);
                WriteLiteral(@"
                    </select>
                </td>
                <td class=""columnwidth"">
                    <select class=""form-control"" id=""add-DowntimeDetail"" onchange=""fncOnchangeDowntimeDetail(this)"" style=""color:mediumvioletred"">
                        ");
                EndContext();
                BeginContext(4206, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88aca7500a3c30a4c9eeebe2ca53ed3fa3b6e2722975", async() => {
                    BeginContext(4224, 17, true);
                    WriteLiteral("--Please Select--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4250, 56, true);
                WriteLiteral("\r\n                    </select>\r\n                </td>\r\n");
                EndContext();
#line 96 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                 foreach (var item1 in Model)
                {

#line default
#line hidden
                BeginContext(4372, 65, true);
                WriteLiteral("                    <td><input type=\"number\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4437, "\"", 4477, 2);
                WriteAttributeValue("", 4442, "add-downtime-", 4442, 13, true);
#line 98 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 4455, item1.stationOrTester, 4455, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4478, 30, true);
                WriteLiteral(" style=\"height:30px\" /></td>\r\n");
                EndContext();
#line 99 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                }

#line default
#line hidden
                BeginContext(4527, 225, true);
                WriteLiteral("                <td>\r\n                    <a id=\"btn-add-downtime\" class=\"btn default btn-xs purple update hiddenTab\" title=\"Add\"> <span class=\"glyphicon glyphicon-plus\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 104 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
             foreach (var i in downtimeDetail)
            {

#line default
#line hidden
                BeginContext(4815, 66, true);
                WriteLiteral("                <tr class=\"text-center\">\r\n                    <td>");
                EndContext();
                BeginContext(4882, 14, false);
#line 107 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                   Write(i.DowntimeType);

#line default
#line hidden
                EndContext();
                BeginContext(4896, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(4928, 16, false);
#line 108 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                   Write(i.DowntimeDetail);

#line default
#line hidden
                EndContext();
                BeginContext(4944, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 109 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                     foreach (var item1 in Model)
                    {

#line default
#line hidden
                BeginContext(5025, 27, true);
                WriteLiteral("                        <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 5052, "\"", 5113, 5);
#line 111 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 5057, i.DowntimeType, 5057, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 5072, "-", 5072, 1, true);
#line 111 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 5073, i.DowntimeDetail, 5073, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 5090, "-", 5090, 1, true);
#line 111 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
WriteAttributeValue("", 5091, item1.stationOrTester, 5091, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5114, 36, true);
                WriteLiteral(" ondblclick=\"addInput(this)\"></td>\r\n");
                EndContext();
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                    }

#line default
#line hidden
                BeginContext(5173, 157, true);
                WriteLiteral("                    <td class=\"text-center\">\r\n                        <a id=\"btn-edit-downtime\" class=\"btn default btn-xs purple update \" data-downtimeType=\"");
                EndContext();
                BeginContext(5331, 14, false);
#line 114 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                                                          Write(i.DowntimeType);

#line default
#line hidden
                EndContext();
                BeginContext(5345, 23, true);
                WriteLiteral("\" data-downtimeDetail=\"");
                EndContext();
                BeginContext(5369, 16, false);
#line 114 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
                                                                                                                                                Write(i.DowntimeDetail);

#line default
#line hidden
                EndContext();
                BeginContext(5385, 125, true);
                WriteLiteral("\" title=\"Edit\"> <span class=\"glyphicon glyphicon-floppy-save\"></span></a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 117 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\DataTable.cshtml"
            }

#line default
#line hidden
                BeginContext(5525, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5564, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VStation>> Html { get; private set; }
    }
}
#pragma warning restore 1591