#pragma checksum "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Calculator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bede6c8919f5cdc1728cf2fdee64eeb94189da46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Index), @"mvc.1.0.view", @"/Views/Calculator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Index.cshtml", typeof(AspNetCore.Views_Calculator_Index))]
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
#line 1 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\_ViewImports.cshtml"
using TechElevator.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bede6c8919f5cdc1728cf2fdee64eeb94189da46", @"/Views/Calculator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15b3130b812f13191ba765650a7fffc83bbb741", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Calculator\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int startValue = Convert.ToInt32(ViewData["start"]);

#line default
#line hidden
            BeginContext(101, 181, true);
            WriteLiteral("\r\n<h2>Metric to Imperial</h2>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Metric Unit</th>\r\n            <th>Imperial Unit</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Calculator\Index.cshtml"
           
            for(int i = 0; i < 1000;i += startValue)
            {

#line default
#line hidden
            BeginContext(364, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(411, 1, false);
#line 21 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Calculator\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(412, 37, true);
            WriteLiteral("  km/h</td>\r\n                    <td>");
            EndContext();
            BeginContext(451, 8, false);
#line 22 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Calculator\Index.cshtml"
                    Write(i * 0.62);

#line default
#line hidden
            EndContext();
            BeginContext(460, 34, true);
            WriteLiteral(" mph</td>\r\n                </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Calculator\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(520, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
