#pragma checksum "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdbc72a6214444bf51f3706f04b1bd8888192cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestTech_GetDowntime_partialview), @"mvc.1.0.view", @"/Views/TestTech/GetDowntime_partialview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestTech/GetDowntime_partialview.cshtml", typeof(AspNetCore.Views_TestTech_GetDowntime_partialview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdbc72a6214444bf51f3706f04b1bd8888192cf4", @"/Views/TestTech/GetDowntime_partialview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f23fa891ddf361532d74fd9125be6d247220007", @"/Views/_ViewImports.cshtml")]
    public class Views_TestTech_GetDowntime_partialview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VActivities>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Planned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Unplanned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 160, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"caption col-md-12\">\r\n    <span class=\"caption-subject font-green-sharp bold uppercase\">\r\n        Unplanned Downtime\r\n    </span>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(213, 2341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff61dc606e654e988042e1d76847b796", async() => {
                BeginContext(219, 708, true);
                WriteLiteral(@"
    <table class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr class=""text-center bold"">
                <td style=""width:50px"">Type</td>
                <td style=""width:50px"">Station/Tester</td>
                <td style=""width:50px"">Detail</td>
                <td style=""width:50px"">Duration (mins)</td>
                <td class=""columnwidth"">Modification</td>
            </tr>
        </thead>
        <tbody>
            <tr class=""text-center"">
                <td id=""DowntimeType"" class=""columnwidth"">
                    <select class=""form-control"" id=""txt-wc"" data-search=""wc"" name=""wc"" style=""color:mediumvioletred"">
                        ");
                EndContext();
                BeginContext(927, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61c65e2d6d0c4f4d8cb3d7093b2fd252", async() => {
                    BeginContext(944, 17, true);
                    WriteLiteral("--Please Select--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(970, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(996, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f64e40a36f944f269790af30b486081d", async() => {
                    BeginContext(1020, 7, true);
                    WriteLiteral("Planned");
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
                BeginContext(1036, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1062, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6202b5dcc52f43d093aa60a0631c9aa6", async() => {
                    BeginContext(1088, 9, true);
                    WriteLiteral("Unplanned");
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
                BeginContext(1106, 671, true);
                WriteLiteral(@"
                    </select>
                </td>
                <td id=""StationOrTester"" class=""columnwidth""><input type=""text"" class=""form-control"" style=""height:30px"" /></td>
                <td id=""DowntimeDetail"" class=""columnwidth""><input type=""text"" class=""form-control"" style=""height:30px"" /></td>
                <td id=""Duration"" class=""columnwidth""><input type=""number"" class=""form-control"" style=""height:30px"" /></td>
                <td class=""text-center"">
                    <a id=""add-downtime"" class=""btn default btn-xs purple update"" title=""Add""> <span class=""glyphicon glyphicon-plus""></span></a>
                </td>
            </tr>
");
                EndContext();
#line 39 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1834, 65, true);
                WriteLiteral("                <tr class=\"text-center\">\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1899, "\"", 1922, 1);
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
WriteAttributeValue("", 1904, item.DowntimeType, 1904, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1923, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(1945, 17, false);
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
                                                               Write(item.DowntimeType);

#line default
#line hidden
                EndContext();
                BeginContext(1962, 31, true);
                WriteLiteral(" </td>\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1993, "\"", 2019, 1);
#line 43 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
WriteAttributeValue("", 1998, item.StationOrTester, 1998, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2020, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(2042, 20, false);
#line 43 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
                                                                  Write(item.StationOrTester);

#line default
#line hidden
                EndContext();
                BeginContext(2062, 31, true);
                WriteLiteral(" </td>\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2093, "\"", 2118, 1);
#line 44 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
WriteAttributeValue("", 2098, item.DowntimeDetail, 2098, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2119, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(2141, 19, false);
#line 44 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
                                                                 Write(item.DowntimeDetail);

#line default
#line hidden
                EndContext();
                BeginContext(2160, 33, true);
                WriteLiteral(" </td>\r\n\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2193, "\"", 2212, 1);
#line 46 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
WriteAttributeValue("", 2198, item.Duration, 2198, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2213, 21, true);
                WriteLiteral(" class=\"columnwidth\">");
                EndContext();
                BeginContext(2235, 13, false);
#line 46 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
                                                           Write(item.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(2248, 80, true);
                WriteLiteral(" </td>\r\n                    <td class=\"text-center\">\r\n                        <a");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2328, "\"", 2341, 1);
#line 48 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
WriteAttributeValue("", 2333, item.Id, 2333, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2342, 158, true);
                WriteLiteral(" class=\"btn default btn-xs purple update\" title=\"Edit\"> <span class=\"glyphicon glyphicon-edit\"></span></a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 51 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\GetDowntime_partialview.cshtml"
            }

#line default
#line hidden
                BeginContext(2515, 32, true);
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
            BeginContext(2554, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VActivities>> Html { get; private set; }
    }
}
#pragma warning restore 1591