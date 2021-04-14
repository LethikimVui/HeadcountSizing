#pragma checksum "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a028e0201278e585aea24ebf2e1b850324c9aaa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestTech_GetTestData), @"mvc.1.0.view", @"/Views/TestTech/GetTestData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestTech/GetTestData.cshtml", typeof(AspNetCore.Views_TestTech_GetTestData))]
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
#line 1 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\_ViewImports.cshtml"
using HCSizing;

#line default
#line hidden
#line 2 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\_ViewImports.cshtml"
using HCSizing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a028e0201278e585aea24ebf2e1b850324c9aaa4", @"/Views/TestTech/GetTestData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f23fa891ddf361532d74fd9125be6d247220007", @"/Views/_ViewImports.cshtml")]
    public class Views_TestTech_GetTestData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VStation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-equipment-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Planned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Unplanned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
  
    ViewData["Title"] = "GetAllColumnName";
    var months = new List<string> { "Sep", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
    var downtimeDetail = ViewData["downtimeDetail"] as IEnumerable<SharedObjects.ValueObjects.VDowntime>;

#line default
#line hidden
            BeginContext(332, 382, true);
            WriteLiteral(@"
<div class=""caption col-md-12"">
    <span class=""caption-subject font-green-sharp bold uppercase"">
        Equipment Data Entrance
    </span>
    <span class=""caption-subject font-green-sharp bold uppercase"">
        <a class=""btn btn-success"" id=""btn-add-equipemnt-stationOrTester"" data-toggle=""modal"" style=""visibility:hidden"">Add Station Data</a>
    </span>
</div>

");
            EndContext();
            BeginContext(714, 1887, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5fb97f144224147967908c5c9b1e8b4", async() => {
                BeginContext(744, 551, true);
                WriteLiteral(@"
    <table id=""tbl-equipment"" class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr class=""text-center bold"">
                <td style=""width:50px"">
                    Fiscal Year
                </td>
                <td style=""width:50px"">
                    Month
                </td>
                <td class=""columnwidth""><input id=""txt-add-equipment-stationOrTester"" onchange=""fncOnchangeStationOrTester()"" class=""form-control uppercase"" name=""addStationOrTester"" style=""height:30px"" /></td>

");
                EndContext();
#line 29 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(1360, 23, true);
                WriteLiteral("                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1383, "\"", 1409, 1);
#line 31 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 1388, item.stationOrTester, 1388, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1410, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(1432, 20, false);
#line 31 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                  Write(item.stationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(1452, 12, true);
                WriteLiteral(" (Qty) </td>");
                EndContext();
#line 31 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                                                        }

#line default
#line hidden
                BeginContext(1467, 129, true);
                WriteLiteral("                <td class=\"columnwidth\">Modification</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"table-data\">\r\n");
                EndContext();
#line 36 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
             foreach (var month in months)
            {

#line default
#line hidden
                BeginContext(1655, 161, true);
                WriteLiteral("                <tr class=\"text-center\">\r\n                    <td>\r\n                        FY21\r\n                    </td>\r\n                    <td data-month=\"");
                EndContext();
                BeginContext(1817, 5, false);
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                               Write(month);

#line default
#line hidden
                EndContext();
                BeginContext(1822, 2, true);
                WriteLiteral("\">");
                EndContext();
                BeginContext(1825, 5, false);
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                       Write(month);

#line default
#line hidden
                EndContext();
                BeginContext(1830, 83, true);
                WriteLiteral("</td>\r\n                    <td class=\"columnwidth\">\r\n                        <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1913, "\"", 1942, 2);
                WriteAttributeValue("", 1918, "txt-add-equipment-", 1918, 18, true);
#line 44 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 1936, month, 1936, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1943, 87, true);
                WriteLiteral(" type=\"number\" class=\"form-control\" style=\"height:30px\" />\r\n                    </td>\r\n");
                EndContext();
#line 46 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                     foreach (var item1 in Model)
                    {

#line default
#line hidden
                BeginContext(2104, 27, true);
                WriteLiteral("                        <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2131, "\"", 2165, 3);
#line 48 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 2136, month, 2136, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 2142, "-", 2142, 1, true);
#line 48 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 2143, item1.stationOrTester, 2143, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2166, 19, true);
                WriteLiteral(" data-stationname=\"");
                EndContext();
                BeginContext(2186, 21, false);
#line 48 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                            Write(item1.stationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(2207, 37, true);
                WriteLiteral("\" ondblclick=\"addInput(this)\"></td>\r\n");
                EndContext();
#line 49 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                    }

#line default
#line hidden
                BeginContext(2267, 149, true);
                WriteLiteral("                    <td class=\"text-center\">\r\n                        <a id=\"btn-editdebugdata\" class=\"btn default btn-xs purple update\" data-month=\"");
                EndContext();
                BeginContext(2417, 5, false);
#line 51 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                                                  Write(month);

#line default
#line hidden
                EndContext();
                BeginContext(2422, 125, true);
                WriteLiteral("\" title=\"Edit\"> <span class=\"glyphicon glyphicon-floppy-save\"></span></a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 54 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
            }

#line default
#line hidden
                BeginContext(2562, 32, true);
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
            BeginContext(2601, 152, true);
            WriteLiteral("\r\n\r\n<div class=\"caption col-md-12\">\r\n    <span class=\"caption-subject font-green-sharp bold uppercase\">\r\n        Downtime Entry\r\n    </span>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2753, 2700, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9912fd75f1864009bd88fef19a89138d", async() => {
                BeginContext(2759, 334, true);
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
#line 75 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(3158, 23, true);
                WriteLiteral("                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3181, "\"", 3207, 1);
#line 77 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 3186, item.stationOrTester, 3186, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3208, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(3230, 20, false);
#line 77 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                  Write(item.stationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(3250, 16, true);
                WriteLiteral(" (mins/day)</td>");
                EndContext();
#line 77 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                                                            }

#line default
#line hidden
                BeginContext(3269, 362, true);
                WriteLiteral(@"                <td class=""columnwidth"">Modification</td>
            </tr>
        </thead>
        <tbody id="""">
            <tr class=""text-center"">
                <td class=""columnwidth"">
                    <select class=""form-control"" id=""txt-dowtimetype"" style=""color:mediumvioletred"" onchange=""fncOnchangeDowntimeType()"">
                        ");
                EndContext();
                BeginContext(3631, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf5a20d1d564325b736bd1b70b0458b", async() => {
                    BeginContext(3649, 31, true);
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
                BeginContext(3689, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3715, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fae04512326042079c235cc5ed2cf6e2", async() => {
                    BeginContext(3739, 7, true);
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
                BeginContext(3755, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3781, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96c513c0df542198ed70e5c201f7add", async() => {
                    BeginContext(3807, 9, true);
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
                BeginContext(3825, 270, true);
                WriteLiteral(@"
                    </select>
                </td>
                <td class=""columnwidth"">
                    <select class=""form-control"" id=""add-DowntimeDetail"" onchange=""fncOnchangeDowntimeDetail(this)"" style=""color:mediumvioletred"">
                        ");
                EndContext();
                BeginContext(4095, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "935d65ac1bfb4e01b98aee111ccbb48a", async() => {
                    BeginContext(4113, 17, true);
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
                BeginContext(4139, 56, true);
                WriteLiteral("\r\n                    </select>\r\n                </td>\r\n");
                EndContext();
#line 95 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                 foreach (var item1 in Model)
                {

#line default
#line hidden
                BeginContext(4261, 65, true);
                WriteLiteral("                    <td><input type=\"number\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4326, "\"", 4366, 2);
                WriteAttributeValue("", 4331, "add-downtime-", 4331, 13, true);
#line 97 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 4344, item1.stationOrTester, 4344, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4367, 30, true);
                WriteLiteral(" style=\"height:30px\" /></td>\r\n");
                EndContext();
#line 98 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                }

#line default
#line hidden
                BeginContext(4416, 225, true);
                WriteLiteral("                <td>\r\n                    <a id=\"btn-add-downtime\" class=\"btn default btn-xs purple update hiddenTab\" title=\"Add\"> <span class=\"glyphicon glyphicon-plus\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 103 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
             foreach (var i in downtimeDetail)
            {

#line default
#line hidden
                BeginContext(4704, 66, true);
                WriteLiteral("                <tr class=\"text-center\">\r\n                    <td>");
                EndContext();
                BeginContext(4771, 14, false);
#line 106 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                   Write(i.DowntimeType);

#line default
#line hidden
                EndContext();
                BeginContext(4785, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(4817, 16, false);
#line 107 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                   Write(i.DowntimeDetail);

#line default
#line hidden
                EndContext();
                BeginContext(4833, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 108 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                     foreach (var item1 in Model)
                    {

#line default
#line hidden
                BeginContext(4914, 27, true);
                WriteLiteral("                        <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4941, "\"", 5002, 5);
#line 110 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 4946, i.DowntimeType, 4946, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 4961, "-", 4961, 1, true);
#line 110 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 4962, i.DowntimeDetail, 4962, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 4979, "-", 4979, 1, true);
#line 110 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
WriteAttributeValue("", 4980, item1.stationOrTester, 4980, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5003, 36, true);
                WriteLiteral(" ondblclick=\"addInput(this)\"></td>\r\n");
                EndContext();
#line 111 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                    }

#line default
#line hidden
                BeginContext(5062, 157, true);
                WriteLiteral("                    <td class=\"text-center\">\r\n                        <a id=\"btn-edit-downtime\" class=\"btn default btn-xs purple update \" data-downtimeType=\"");
                EndContext();
                BeginContext(5220, 14, false);
#line 113 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                                                          Write(i.DowntimeType);

#line default
#line hidden
                EndContext();
                BeginContext(5234, 23, true);
                WriteLiteral("\" data-downtimeDetail=\"");
                EndContext();
                BeginContext(5258, 16, false);
#line 113 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
                                                                                                                                                Write(i.DowntimeDetail);

#line default
#line hidden
                EndContext();
                BeginContext(5274, 125, true);
                WriteLiteral("\" title=\"Edit\"> <span class=\"glyphicon glyphicon-floppy-save\"></span></a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 116 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetTestData.cshtml"
            }

#line default
#line hidden
                BeginContext(5414, 32, true);
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
            BeginContext(5453, 8, true);
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