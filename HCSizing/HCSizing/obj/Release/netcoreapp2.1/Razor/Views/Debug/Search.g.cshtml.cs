#pragma checksum "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88791f08670069b643a1180cf77b790a60850a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Debug_Search), @"mvc.1.0.view", @"/Views/Debug/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Debug/Search.cshtml", typeof(AspNetCore.Views_Debug_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88791f08670069b643a1180cf77b790a60850a70", @"/Views/Debug/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f23fa891ddf361532d74fd9125be6d247220007", @"/Views/_ViewImports.cshtml")]
    public class Views_Debug_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedObjects.ViewModels.AddDebugRawDataViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tableToExcel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/debughcs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\Search.cshtml"
  
    var NTID = User.Identity.Name.Split("\\")[1];

    var WCs = ViewData["WCs"] as IEnumerable<SharedObjects.ValueObjects.VWC>
    ;
    ViewData["Title"] = "Search";
    ViewData["NTID"] = NTID;
    ViewData["displayName"] = ViewData["displayName"];


#line default
#line hidden
            BeginContext(328, 637, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""height:1700px"">
                <div class=""portlet-title"">

                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Debug Headcount Sizing
                        </span>

                    </div>

                    <div class=""portlet-body"">

                        <div class=""table-toolbar"">
                            ");
            EndContext();
            BeginContext(965, 1347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2b86dc203ae4e5fabe39aeb19dafed7", async() => {
                BeginContext(996, 459, true);
                WriteLiteral(@"
                                <div class=""pull-left"">

                                    <label class=""text-center bold font-green-sharp"" for=""txt-WC"">WorkCell</label>
                                </div>
                                <div class=""col-md-3 pull-left"">
                                    <select class=""form-control"" id=""txt-wc"" data-search=""wc"" name=""wc"" style=""color:mediumvioletred"">
                                        ");
                EndContext();
                BeginContext(1455, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e64cb0e7bdc4100b91a084ec0cedc47", async() => {
                    BeginContext(1473, 17, true);
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
                BeginContext(1499, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 40 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\Search.cshtml"
                                         foreach (var item in @WCs.OrderByDescending(c => c.Wcname).ToList())
                                            {

#line default
#line hidden
                BeginContext(1661, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1701, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e18d42a3db0445cdb80f682ff5704677", async() => {
                    BeginContext(1729, 11, false);
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\Search.cshtml"
                                                              Write(item.Wcname);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\Search.cshtml"
                                          WriteLiteral(item.Wcname);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1749, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\Debug\Search.cshtml"
                                            }

#line default
#line hidden
                BeginContext(1798, 507, true);
                WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""col-md-1  pull-left"">
                                    <a class=""btn btn-success"" id=""btn-search"">Search</a>
                                </div>
                                <div class=""col-md-1 pull-left box"" id=""box""></div>
                                <div class=""col-md-1  pull-left"">
                                </div>

                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2312, 750, true);
            WriteLiteral(@"
                        </div>
                        <hr style=""height:5px"" />

                    </div>
                </div>
                <div id=""table-rawdata"" class=""table-responsive col-md-12 table-responsive"" style=""height:500px"">


                </div>
                <div id=""table-debugdata"" class=""table-responsive col-md-12 table-responsive"" style=""height:250px"">

                </div>
                <div id=""table-debugresult"" class=""table-responsive col-md-12 table-responsive"" style=""height:700px"">

                </div>
            </div>
        </div>
    </div>
</div>


<!--Modal debug RAW data - update-->
<!-- Kết thúc Modal debug RAW data - update-->
<!--Modal debug data - update-->
");
            EndContext();
            BeginContext(6715, 43, true);
            WriteLiteral("<!--Kết thúc Modal debug data - update-->\r\n");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(6774, 2936, true);
                WriteLiteral(@"
    <script>
        function fncOnChangeTech(loggedTech, month) {
            debugger
            var crrr = `#Current-${month}`;
            var calculated = $(`${crrr}`).text();
            var result = loggedTech - calculated;
            if (result == 0) {
                $(`${crrr}`).attr(""style"", ""background-color: yellow"");
            }
            else if (result < 0) {
                $(`${crrr}`).attr(""style"", ""background-color: red"");
            }
            else {
                $(`${crrr}`).attr(""style"", ""background-color: green"");
            }
        }
        function fncOnChangeOperator(loggedOP, month) {
            debugger
            var crrr = `#Current-${month}`;
            var calculated = $(`${crrr}`).text();
            var result = loggedOP - calculated;
            if (result == 0) {
                $(`${crrr}`).attr(""style"", ""background-color: yellow"");
            }
            else if (result < 0) {
                $(`${crrr}`).attr(""style"", ""b");
                WriteLiteral(@"ackground-color: red"");
            }
            else {
                $(`${crrr}`).attr(""style"", ""background-color: green"");
            }
        }


        function closeInput(elm) {
            var td = elm.parentNode;
            var value = elm.value;
            td.setAttribute('style', 'background-color:cyan')
            td.removeChild(elm);
            td.innerHTML = value;
        }

        function addInput(elm) {
            if (elm.getElementsByTagName('input').length > 0) return;

            var value = elm.innerHTML;
            elm.innerHTML = '';

            var input = document.createElement('input');
            input.setAttribute('type', 'number');
            input.setAttribute('value', value);
            input.setAttribute('onBlur', 'closeInput(this)');
            input.setAttribute('style', 'width:100px');
            elm.appendChild(input);
            input.focus();
        }
        function addSelect(elm) {
            if (elm.getElementsByTag");
                WriteLiteral(@"Name('select').length > 0) return;

            var value = elm.innerHTML;
            elm.innerHTML = '';

            var select = document.createElement('select');
            $(select).append(""<option value='4-3'>4-3</option>"");
            $(select).append(""<option value='4-2'>4-2</option>"");
            $(select).append(""<option value='Regular Shift'>Regular Shift</option>"");
            select.setAttribute('value', value);
            select.setAttribute('onBlur', 'closeSelect(this)');

            elm.appendChild(select);
            select.focus();
        }
        function closeSelect(elm) {
            var td = elm.parentNode;
            var value = elm.value;
            debugger
            td.setAttribute('style', 'background-color:cyan')
            td.removeChild(elm);
            td.innerHTML = value;
        }

    </script>

    ");
                EndContext();
                BeginContext(9710, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adfa2e93f91a404cae66af59d4247929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9754, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(9875, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(9879, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99dac5d0f364bb787ac054dd79ac7f7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9919, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(9971, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedObjects.ViewModels.AddDebugRawDataViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
