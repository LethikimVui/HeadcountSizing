#pragma checksum "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7343919b6399851ee38f3a62b1e3f1d21ed674f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Debug_GetDebugResult_partialview), @"mvc.1.0.view", @"/Views/Debug/GetDebugResult_partialview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Debug/GetDebugResult_partialview.cshtml", typeof(AspNetCore.Views_Debug_GetDebugResult_partialview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7343919b6399851ee38f3a62b1e3f1d21ed674f9", @"/Views/Debug/GetDebugResult_partialview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f23fa891ddf361532d74fd9125be6d247220007", @"/Views/_ViewImports.cshtml")]
    public class Views_Debug_GetDebugResult_partialview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VDebugResult>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-save-loggedheadcount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
  
    var Months = ViewData["Months"] as List<string>;

#line default
#line hidden
            BeginContext(115, 158, true);
            WriteLiteral("\r\n<div class=\"caption col-md-12\">\r\n    <span class=\"caption-subject font-green-sharp bold uppercase\">\r\n        Current Locked Headcount\r\n    </span>\r\n</div>\r\n");
            EndContext();
            BeginContext(273, 1189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40f40c68b5014a62b11aadb25eba3dc9", async() => {
                BeginContext(309, 209, true);
                WriteLiteral("\r\n    <table class=\"table table-bordered table-hover table-striped \">\r\n        <thead>\r\n\r\n            <tr class=\"text-center bold\">\r\n                <td>\r\n                    Locked HC\r\n                </td>\r\n");
                EndContext();
#line 19 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                 foreach (var month in Months)
                {

#line default
#line hidden
                BeginContext(585, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(610, 5, false);
#line 21 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                   Write(month);

#line default
#line hidden
                EndContext();
                BeginContext(615, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 22 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                }

#line default
#line hidden
                BeginContext(641, 225, true);
                WriteLiteral("                <td>Modification</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"\">\r\n           \r\n            <tr class=\"text-center\">\r\n                <td>\r\n                    Operator\r\n                </td>\r\n");
                EndContext();
#line 32 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                 foreach (var month in Months)
                {

#line default
#line hidden
                BeginContext(933, 90, true);
                WriteLiteral("                    <td class=\"text-center\">\r\n                        <input type=\"number\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1023, "\"", 1037, 2);
                WriteAttributeValue("", 1028, "OP-", 1028, 3, true);
#line 35 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
WriteAttributeValue("", 1031, month, 1031, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1038, 67, true);
                WriteLiteral(" onchange=\"fncOnChangeOperator(this.value, this.id)\" onload=\"fnc()\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1105, "\"", 1118, 1);
#line 35 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
WriteAttributeValue("", 1112, month, 1112, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1119, 51, true);
                WriteLiteral(" style=\"width:50px\" />\r\n                    </td>\r\n");
                EndContext();
#line 37 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                }

#line default
#line hidden
                BeginContext(1189, 266, true);
                WriteLiteral(@"                <td class=""text-center"">
                    <a id=""btn-OP"" class=""btn default btn-xs purple update"" title=""Save""> <span class=""glyphicon glyphicon-floppy-saved""></span></a>
                </td>
            </tr>
        </tbody>
    </table>
");
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
            BeginContext(1462, 1090, true);
            WriteLiteral(@"
<div class=""table-responsive col-md-11 table-responsive"">
    <span class=""caption-subject font-green-sharp bold uppercase"">
        Headcount needed
    </span>

</div>
<div class=""table-responsive col-md-1 table-responsive pull-right"">
    <a class=""btn btn-success"" id=""btn-save-headcount"">Save</a>
    <div style=""height:15px"">
    </div>
</div>

<table id=""tbl-debugresult"" class=""table table-bordered table-hover table-striped"">
    <thead>
        <tr class=""text-center bold"">
            <td>Fiscal Year</td>
            <td>Month</td>
            <td>Calculated Number of Operator</td>
            <td>Calculated Number of Operator (Round Up)</td>
            <td>Current Locked Operator Number</td>
            <td><span data-toggle=""tooltip"" id=""addItInfo"" data-html=""true"" title=""Some<em>Tooltip</em> <u>with</u> <b>bold words</b>"">Calculated Number of Technician</span></td>
            <td>Calculated Number of Technician (Round Up)</td>
            <td>Current Locked Technician Numbe");
            WriteLiteral("r</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"table-data\">\r\n");
            EndContext();
#line 71 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2601, 74, true);
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td id=\"FiscalYear\">");
            EndContext();
            BeginContext(2676, 15, false);
#line 74 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                               Write(item.FiscalYear);

#line default
#line hidden
            EndContext();
            BeginContext(2691, 38, true);
            WriteLiteral("</td>\r\n                <td id=\"Month\">");
            EndContext();
            BeginContext(2730, 10, false);
#line 75 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                          Write(item.Month);

#line default
#line hidden
            EndContext();
            BeginContext(2740, 41, true);
            WriteLiteral("</td>\r\n                <td id=\"RawOPNum\">");
            EndContext();
            BeginContext(2782, 17, false);
#line 76 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                             Write(item.CalculatedOP);

#line default
#line hidden
            EndContext();
            BeginContext(2799, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2825, "\"", 2850, 2);
            WriteAttributeValue("", 2830, "ActualOP-", 2830, 9, true);
#line 77 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
WriteAttributeValue("", 2839, item.Month, 2839, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2851, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2853, 14, false);
#line 77 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                                         Write(item.RoundUpOP);

#line default
#line hidden
            EndContext();
            BeginContext(2867, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2893, "\"", 2920, 2);
            WriteAttributeValue("", 2898, "Current-OP-", 2898, 11, true);
#line 78 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
WriteAttributeValue("", 2909, item.Month, 2909, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2921, 29, true);
            WriteLiteral(" ondblclick=\"addInput(this)\">");
            EndContext();
            BeginContext(2951, 19, false);
#line 78 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                                                                       Write(item.LockedOperator);

#line default
#line hidden
            EndContext();
            BeginContext(2970, 43, true);
            WriteLiteral("</td>\r\n                <td id=\"RawTechNum\">");
            EndContext();
            BeginContext(3014, 19, false);
#line 79 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                               Write(item.CalculatedTech);

#line default
#line hidden
            EndContext();
            BeginContext(3033, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3059, "\"", 3090, 2);
            WriteAttributeValue("", 3064, "calculatedTech-", 3064, 15, true);
#line 80 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
WriteAttributeValue("", 3079, item.Month, 3079, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3091, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3093, 16, false);
#line 80 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                                               Write(item.RoundUpTech);

#line default
#line hidden
            EndContext();
            BeginContext(3109, 26, true);
            WriteLiteral("</td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3135, "\"", 3162, 2);
            WriteAttributeValue("", 3140, "lockedTech-", 3140, 11, true);
#line 81 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
WriteAttributeValue("", 3151, item.Month, 3151, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3163, 29, true);
            WriteLiteral(" ondblclick=\"addInput(this)\">");
            EndContext();
            BeginContext(3193, 15, false);
#line 81 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
                                                                       Write(item.LockedTech);

#line default
#line hidden
            EndContext();
            BeginContext(3208, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\GetDebugResult_partialview.cshtml"
        }

#line default
#line hidden
            BeginContext(3245, 750, true);
            WriteLiteral(@"    </tbody>
</table>

<div>
    <label>Legend:</label>
</div>
<div>
    <div style=""float: left;width: 15px; height: 10px; margin: 5px;border: 1px solid rgba(0, 0, 0, .2);background: #00C851;"">

    </div>
    <p style=""font-size:9px"">
        Caculated Tech = Current Logged Tech
    </p>
    <div style=""float: left;width: 15px; height: 10px; margin: 5px;border: 1px solid rgba(0, 0, 0, .2);background: red;""></div>
    <p style=""font-size:8px"">
        Caculated Tech > Current Logged Tech
    </p>
    <div style=""float: left;width: 15px; height: 10px; margin: 5px;border: 1px solid rgba(0, 0, 0, .2);background: #FFFFB1;""></div>
    <p style=""font-size:9px"">
        Caculated Tech < Current Logged Tech
    </p>
</div>

");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(4011, 122, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(function () {\r\n            $(\'[data-toggle=\"tooltip\"]\').tooltip()\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VDebugResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591