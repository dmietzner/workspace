#pragma checksum "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4eb7fffecd8c053f8b135c6e690893f74e00fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Index), @"mvc.1.0.view", @"/Views/Films/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Index.cshtml", typeof(AspNetCore.Views_Films_Index))]
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
#line 1 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\_ViewImports.cshtml"
using TechElevator.Web;

#line default
#line hidden
#line 2 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\_ViewImports.cshtml"
using TechElevator.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f4eb7fffecd8c053f8b135c6e690893f74e00fc", @"/Views/Films/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ab670b8c62eed2fe4dc66d1b47b3721292387e", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Film>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Films", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(65, 31, true);
            WriteLiteral("\r\n<h2>All Films</h2>\r\n\r\n<div>\r\n");
            EndContext();
#line 11 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
     foreach (Film movie in Model)
    {

#line default
#line hidden
            BeginContext(139, 37, true);
            WriteLiteral("    <div class=\"movie\">\r\n        <h3>");
            EndContext();
            BeginContext(177, 10, false);
#line 14 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
       Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(187, 28, true);
            WriteLiteral("</h3>\r\n        <p>Released: ");
            EndContext();
            BeginContext(216, 18, false);
#line 15 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
                Write(movie.YearReleased);

#line default
#line hidden
            EndContext();
            BeginContext(234, 14, true);
            WriteLiteral("</p>\r\n        ");
            EndContext();
            BeginContext(248, 402, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddfd931689c644b58a454f323e367f0d", async() => {
                BeginContext(325, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 17 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
              
                if (String.IsNullOrEmpty(movie.ImageUrl))
                {

#line default
#line hidden
                BeginContext(421, 70, true);
                WriteLiteral("                    <img src=\"http://via.placeholder.com/768x400\" />\r\n");
                EndContext();
#line 21 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(551, 24, true);
                WriteLiteral("                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 575, "\"", 596, 1);
#line 24 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
WriteAttributeValue("", 581, movie.ImageUrl, 581, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(597, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 25 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"

                }
            

#line default
#line hidden
                BeginContext(638, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movie_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
                                                              WriteLiteral(movie.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movie_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movie_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movie_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(650, 16, true);
            WriteLiteral("\r\n\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\Student\workspace\danmietzner-c\module-3\34-MVC-Views-Part-2\lecture-final\TechElevator.Web\Views\Films\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(673, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
