#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\Test_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f291e69926ac77970d1ba981414a8e2e09e3c10e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestTech_Test_Partial), @"mvc.1.0.view", @"/Views/TestTech/Test_Partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestTech/Test_Partial.cshtml", typeof(AspNetCore.Views_TestTech_Test_Partial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f291e69926ac77970d1ba981414a8e2e09e3c10e", @"/Views/TestTech/Test_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19231971b9cfd504b87d99906ea6f0243cbc0247", @"/Views/_ViewImports.cshtml")]
    public class Views_TestTech_Test_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VStation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\Test_Partial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(85, 52, true);
            WriteLiteral("    <label class=\"text-center bold font-green-sharp\"");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 137, "\"", 143, 0);
            EndWriteAttribute();
            BeginContext(144, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(146, 20, false);
#line 5 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\Test_Partial.cshtml"
                                                       Write(item.stationOrTester);

#line default
#line hidden
            EndContext();
            BeginContext(166, 20, true);
            WriteLiteral("</label>\r\n    <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 186, "\"", 212, 1);
#line 6 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\Test_Partial.cshtml"
WriteAttributeValue("", 191, item.stationOrTester, 191, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(213, 40, true);
            WriteLiteral(" type=\"number\" class=\"form-control\" />\r\n");
            EndContext();
#line 7 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\HCS\HCS\HeadCountSizingPRD\Views\TestTech\Test_Partial.cshtml"
}

#line default
#line hidden
            BeginContext(256, 49, true);
            WriteLiteral("\r\n<a class=\"btn btn-success\" id=\"btn-add\">Add</a>");
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