#pragma checksum "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5b6bf593bb84bf4883da3fdd086f59bd6a13628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Greeting), @"mvc.1.0.view", @"/Views/Home/Greeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Greeting.cshtml", typeof(AspNetCore.Views_Home_Greeting))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5b6bf593bb84bf4883da3fdd086f59bd6a13628", @"/Views/Home/Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15b3130b812f13191ba765650a7fffc83bbb741", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Greeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
  
    ViewData["Title"] = "Greeting";
    string lastName = "Gates";
    string firstName = "Bill";

#line default
#line hidden
            BeginContext(110, 50, true);
            WriteLiteral("\r\n<p>This page renders the current date and time: ");
            EndContext();
            BeginContext(161, 31, false);
#line 8 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
                                           Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(192, 45, true);
            WriteLiteral(" </p>\r\n\r\n<p>Welcome <span class=\"boldItalic\">");
            EndContext();
            BeginContext(238, 9, false);
#line 10 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
                               Write(firstName);

#line default
#line hidden
            EndContext();
            BeginContext(247, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(249, 8, false);
#line 10 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
                                          Write(lastName);

#line default
#line hidden
            EndContext();
            BeginContext(257, 15, true);
            WriteLiteral("</span></p>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
   
    if(DateTime.Now.Hour < 12)
    {

#line default
#line hidden
            BeginContext(316, 24, true);
            WriteLiteral("        <p>Good morning ");
            EndContext();
            BeginContext(341, 9, false);
#line 15 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
                   Write(firstName);

#line default
#line hidden
            EndContext();
            BeginContext(350, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
    } else
    {

#line default
#line hidden
            BeginContext(375, 38, true);
            WriteLiteral("        <p>Good afternoon/evening Mr. ");
            EndContext();
            BeginContext(414, 8, false);
#line 18 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
                                 Write(lastName);

#line default
#line hidden
            EndContext();
            BeginContext(422, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
    }

#line default
#line hidden
            BeginContext(438, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
   
    for(int i = 0; i < 1000; i++)
    {

#line default
#line hidden
            BeginContext(487, 17, true);
            WriteLiteral("        <p>Hello ");
            EndContext();
            BeginContext(505, 9, false);
#line 25 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
            Write(firstName);

#line default
#line hidden
            EndContext();
            BeginContext(514, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(516, 8, false);
#line 25 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
                       Write(lastName);

#line default
#line hidden
            EndContext();
            BeginContext(524, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "C:\Users\Student\workspace\danmietzner-c\module-3\33-Introduction-to-MVC-Views\lecture-final\TechElevator.Web\Views\Home\Greeting.cshtml"
    }

#line default
#line hidden
            BeginContext(540, 86, true);
            WriteLiteral("<style>\r\n.boldItalic {\r\n    font-style:italic;\r\n    font-weight:bold;\r\n}\r\n</style>\r\n\r\n");
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
