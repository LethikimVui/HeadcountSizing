#pragma checksum "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64533ad84a94eccb7949749baf26785dfbc872a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestTech_Search), @"mvc.1.0.view", @"/Views/TestTech/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestTech/Search.cshtml", typeof(AspNetCore.Views_TestTech_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64533ad84a94eccb7949749baf26785dfbc872a0", @"/Views/TestTech/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f23fa891ddf361532d74fd9125be6d247220007", @"/Views/_ViewImports.cshtml")]
    public class Views_TestTech_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedObjects.ViewModels.AddDebugRawDataViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tableToExcel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/testTechhcs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\Search.cshtml"
  

    var NTID = User.Identity.Name.Split("\\")[1];

    var WCs = ViewData["WCs"] as IEnumerable<SharedObjects.ValueObjects.VWC>
    ;
    ViewData["Title"] = "Search";
    ViewData["NTID"] = NTID;
    ViewData["displayName"] = ViewData["displayName"];



#line default
#line hidden
            BeginContext(332, 641, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""height:1700px"">
                <div class=""portlet-title"">

                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Test Tech Headcount Sizing
                        </span>

                    </div>

                    <div class=""portlet-body"">

                        <div class=""table-toolbar"">
                            ");
            EndContext();
            BeginContext(973, 1236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71839b9d7292427f80bdc7ed24fd0f00", async() => {
                BeginContext(1004, 459, true);
                WriteLiteral(@"
                                <div class=""pull-left"">

                                    <label class=""text-center bold font-green-sharp"" for=""txt-WC"">WorkCell</label>
                                </div>
                                <div class=""col-md-3 pull-left"">
                                    <select class=""form-control"" id=""txt-wc"" data-search=""wc"" name=""wc"" style=""color:mediumvioletred"">
                                        ");
                EndContext();
                BeginContext(1463, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a75384eb194fbf991b7f65e076753d", async() => {
                    BeginContext(1481, 17, true);
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
                BeginContext(1507, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 42 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\Search.cshtml"
                                         foreach (var item in @WCs.OrderByDescending(c => c.Wcname).ToList())
                                        {

#line default
#line hidden
                BeginContext(1665, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(1709, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09c9b4790b5f4171acf5dc00b4e9a9da", async() => {
                    BeginContext(1737, 11, false);
#line 44 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\Search.cshtml"
                                                                  Write(item.Wcname);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 44 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\Search.cshtml"
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
                BeginContext(1757, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\1099969\Desktop\Development_Project\Web\ASPNETCore\HCSizing\HCSizing\Views\TestTech\Search.cshtml"
                                        }

#line default
#line hidden
                BeginContext(1802, 400, true);
                WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""col-md-1  pull-left"">
                                    <a class=""btn btn-success"" id=""btn-search"">Search</a>
                                </div>

                                <div class=""col-md-1 pull-left box"" id=""box""></div>
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
            BeginContext(2209, 139, true);
            WriteLiteral("\r\n                        </div>\r\n                        <hr style=\"height:5px\" />\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(2423, 337, true);
            WriteLiteral(@"
                <div id=""table-equipment"" class=""table-responsive table-responsive"" style=""height:950px"">


                </div>

                <div id=""table-result"" class=""table-responsive table-responsive"" style=""height:600px"">


                </div>

            </div>
        </div>
    </div>
</div>




");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(2776, 2874, true);
                WriteLiteral(@"
    <script>
        function fncOnchangeStationOrTester() {
            var text = $(""#txt-add-equipment-stationOrTester"").val();
            debugger
            if (text == """") {
                document.getElementById(""btn-add-equipemnt-stationOrTester"").style.visibility = ""hidden"";
            }
            else {
                document.getElementById(""btn-add-equipemnt-stationOrTester"").style.visibility = ""visible"";

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
         ");
                WriteLiteral(@"   input.setAttribute('value', value);
            input.setAttribute('onBlur', 'closeInput(this)');
            input.setAttribute('style', 'width:100px');
            elm.appendChild(input);
            input.focus();
        }

        function fncOnchangeDowntimeType() {
            var _downtimeType = $(""#txt-dowtimetype"").val();
            var _transferWC = $(""#txt-wc"").val();
            $('.hiddenTab').attr(""style"", ""visibility: hidden"");
            $('#add-DowntimeDetail').empty();
            $('#add-DowntimeDetail').append($('<option>', {
                value: ""0"",
                text: ""--Please Select--""
            }));

            var model = new Object();

            model.WC = _transferWC;
            model.DowntimeType = _downtimeType;

            $.ajax({
                type: 'post',
                url: '/hcs/TestTech/GetDowntimeDetailByDowntimeType',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType");
                WriteLiteral(@": ""application/json; charset=utf-8"",
                success: function (response) {
                    var data = response.result;
                    debugger
                    $.each(data, function (index, value) {
                        $('#add-DowntimeDetail').append($('<option>', {
                            value: value.downtimeDetail,
                            text: value.downtimeDetail
                        }));
                    });
                }
            });
        }
        function fncOnchangeDowntimeDetail(el) {
            if ($(el).val() != '0') {
                $('.hiddenTab').attr(""style"", ""visibility: visible"");
            }
            else {
                $('.hiddenTab').attr(""style"", ""visibility: hidden"");
            }
        }

    </script>
    ");
                EndContext();
                BeginContext(5650, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29ffedfc3df84a33bbb2182ce6d06f12", async() => {
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
                BeginContext(5694, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5700, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67833706c229412faeefe994d5d6e29c", async() => {
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
                BeginContext(5743, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(5798, 2, true);
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
