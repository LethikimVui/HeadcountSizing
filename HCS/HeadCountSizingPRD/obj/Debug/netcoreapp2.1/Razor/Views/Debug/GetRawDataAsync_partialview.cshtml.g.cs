#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05b6672ccf8444a3f81c7d5b56a4595603dad374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Debug_GetRawDataAsync_partialview), @"mvc.1.0.view", @"/Views/Debug/GetRawDataAsync_partialview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Debug/GetRawDataAsync_partialview.cshtml", typeof(AspNetCore.Views_Debug_GetRawDataAsync_partialview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b6672ccf8444a3f81c7d5b56a4595603dad374", @"/Views/Debug/GetRawDataAsync_partialview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19231971b9cfd504b87d99906ea6f0243cbc0247", @"/Views/_ViewImports.cshtml")]
    public class Views_Debug_GetRawDataAsync_partialview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VRawData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MonthlyDataEntrance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "debug", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 225, true);
            WriteLiteral("\r\n\r\n<div class=\"caption col-md-12\">\r\n    <span class=\"caption-subject font-green-sharp bold uppercase\">\r\n        Monthly Data Entrance\r\n    </span>\r\n    <span class=\"caption-subject font-green-sharp bold uppercase\">\r\n        ");
            EndContext();
            BeginContext(275, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05b6672ccf8444a3f81c7d5b56a4595603dad3745160", async() => {
                BeginContext(378, 22, true);
                WriteLiteral("one time configuration");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(404, 688, true);
            WriteLiteral(@"
    </span>
</div>
<table id=""tbl-debugrawdata"" class=""table table-bordered table-hover table-striped "">
    <thead>
        <tr class=""text-center bold"">
            <td>Fiscal Year</td>
            <td>Month</td>
            <td>Working Day (days)</td>
            <td>Working Hour Per Shift (hours)</td>
            <td>Shift Pattern</td>
            <td>Working Efficiency (%)</td>
            <td>Forecasted Volume (Qty)</td>
            <td><span data-toggle=""tooltip"" id=""addItInfo"" data-html=""true"" title=""technician coverage"">Coverage (%)</span></td>
            <td>Modification</td>
        </tr>
    </thead>
    <tbody id=""table-data"" class=""text-center"">
");
            EndContext();
#line 27 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1141, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1180, 15, false);
#line 30 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
               Write(item.FiscalYear);

#line default
#line hidden
            EndContext();
            BeginContext(1195, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1223, 10, false);
#line 31 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
               Write(item.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1259, "\"", 1296, 2);
            WriteAttributeValue("", 1264, "WorkingDayPerMonth-", 1264, 19, true);
#line 32 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
WriteAttributeValue("", 1283, item.MonthId, 1283, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1297, 49, true);
            WriteLiteral(" ondblclick=\"addInput(this)\" class=\"text-center\">");
            EndContext();
            BeginContext(1347, 23, false);
#line 32 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                                                     Write(item.WorkingDayPerMonth);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1396, "\"", 1434, 2);
            WriteAttributeValue("", 1401, "WorkingHourPerShift-", 1401, 20, true);
#line 33 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
WriteAttributeValue("", 1421, item.MonthId, 1421, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1435, 29, true);
            WriteLiteral(" ondblclick=\"addInput(this)\">");
            EndContext();
            BeginContext(1465, 24, false);
#line 33 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                                  Write(item.WorkingHourPerShift);

#line default
#line hidden
            EndContext();
            BeginContext(1489, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1515, "\"", 1545, 2);
            WriteAttributeValue("", 1520, "ShiftPatten-", 1520, 12, true);
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
WriteAttributeValue("", 1532, item.MonthId, 1532, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1546, 45, true);
            WriteLiteral(" ondblclick=\"addSelect(this)\" data-shiftId =\"");
            EndContext();
            BeginContext(1592, 12, false);
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                                          Write(item.ShiftId);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1607, 14, false);
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                                                         Write(item.ShiftCode);

#line default
#line hidden
            EndContext();
            BeginContext(1621, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1647, "\"", 1683, 2);
            WriteAttributeValue("", 1652, "WorkingEfficiency-", 1652, 18, true);
#line 35 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
WriteAttributeValue("", 1670, item.MonthId, 1670, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1684, 29, true);
            WriteLiteral(" ondblclick=\"addInput(this)\">");
            EndContext();
            BeginContext(1714, 22, false);
#line 35 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                                Write(item.WorkingEfficiency);

#line default
#line hidden
            EndContext();
            BeginContext(1736, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1762, "\"", 1797, 2);
            WriteAttributeValue("", 1767, "ForecastedVolume-", 1767, 17, true);
#line 36 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
WriteAttributeValue("", 1784, item.MonthId, 1784, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1798, 29, true);
            WriteLiteral(" ondblclick=\"addInput(this)\">");
            EndContext();
            BeginContext(1828, 21, false);
#line 36 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                               Write(item.ForecastedVolume);

#line default
#line hidden
            EndContext();
            BeginContext(1849, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1875, "\"", 1902, 2);
            WriteAttributeValue("", 1880, "Coverage-", 1880, 9, true);
#line 37 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
WriteAttributeValue("", 1889, item.MonthId, 1889, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1903, 29, true);
            WriteLiteral(" ondblclick=\"addInput(this)\">");
            EndContext();
            BeginContext(1933, 13, false);
#line 37 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                       Write(item.Coverage);

#line default
#line hidden
            EndContext();
            BeginContext(1946, 149, true);
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <a id=\"btn-save-rawdata\" class=\"btn default btn-xs purple update\" data-monthId=\"");
            EndContext();
            BeginContext(2096, 12, false);
#line 39 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
                                                                                               Write(item.MonthId);

#line default
#line hidden
            EndContext();
            BeginContext(2108, 118, true);
            WriteLiteral("\" title=\"Save\"> <span class=\"glyphicon glyphicon-floppy-saved\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\Debug\GetRawDataAsync_partialview.cshtml"
        }

#line default
#line hidden
            BeginContext(2237, 24, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VRawData>> Html { get; private set; }
    }
}
#pragma warning restore 1591