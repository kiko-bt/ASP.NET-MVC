#pragma checksum "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6df6173bbf2e3abc504a239ffa047b180a5986e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThankYou), @"mvc.1.0.view", @"/Views/Shared/_ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThankYou.cshtml", typeof(AspNetCore.Views_Shared__ThankYou))]
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
#line 1 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp;

#line default
#line hidden
#line 2 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models;

#line default
#line hidden
#line 3 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models.Domain;

#line default
#line hidden
#line 4 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models.ViewModels;

#line default
#line hidden
#line 5 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df6173bbf2e3abc504a239ffa047b180a5986e5", @"/Views/Shared/_ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fada01253373a4c11a49a1506b9f80f3d288ed94", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 142, true);
            WriteLiteral("\r\n\r\n<h2>Thank You</h2>\r\n<p>Thank you for ordering pizza with PizzaApp and using our application!</p>\r\n\r\n<button class=\"btn btn-primary\">\r\n    ");
            EndContext();
            BeginContext(143, 99, false);
#line 7 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_ThankYou.cshtml"
Write(Html.ActionLink("Order another pizza", "Create", "Order", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(242, 11, true);
            WriteLiteral("\r\n</button>");
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
