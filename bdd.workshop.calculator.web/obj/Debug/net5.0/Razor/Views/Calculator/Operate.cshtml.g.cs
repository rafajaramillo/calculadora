#pragma checksum "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\Calculator\Operate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e29e054bbed90aed1875d2861c639305fb1c9dab737be5769d7d9ea464556bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Operate), @"mvc.1.0.view", @"/Views/Calculator/Operate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\_ViewImports.cshtml"
using bdd.workshop.calculator.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\_ViewImports.cshtml"
using bdd.workshop.calculator.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e29e054bbed90aed1875d2861c639305fb1c9dab737be5769d7d9ea464556bd3", @"/Views/Calculator/Operate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0307c53b6ba81f159df699b819d922e3788ef5667c824928877d26630a6c79c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Calculator_Operate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <table class=""table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Number A</th>
                <th scope=""col"">Operator</th>
                <th scope=""col"">Number B</th>
                <th scope=""col""></th>
                <th scope=""col"">Result</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 17 "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\Calculator\Operate.cshtml"
               Write(ViewData["a"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\Calculator\Operate.cshtml"
               Write(ViewData["operation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\Calculator\Operate.cshtml"
               Write(ViewData["b"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>=</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\SAM\source\repos\calculadora\bdd.workshop.calculator.web\Views\Calculator\Operate.cshtml"
               Write(ViewData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
