#pragma checksum "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df86edfedb6883df0887df5af65779ecf1a08399"
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
#line 1 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\_ViewImports.cshtml"
using PizzaApp.Refactored;

#line default
#line hidden
#line 2 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\_ViewImports.cshtml"
using PizzaApp.Refactored.Models;

#line default
#line hidden
#line 3 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\_ViewImports.cshtml"
using PizzaApp.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df86edfedb6883df0887df5af65779ecf1a08399", @"/Views/Shared/_ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db3745d783dfde69dbaf04201c970134901cde7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_ThankYou.cshtml"
   ViewBag.Title = "Thank You"; 

#line default
#line hidden
            BeginContext(35, 183, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>Thank you for ordering</h1>\r\n    <p>Order again or leave us a feedback so we can improve!</p>\r\n    <p>\r\n        <button class=\"btn btn-danger btn-lg\">");
            EndContext();
            BeginContext(219, 48, false);
#line 6 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_ThankYou.cshtml"
                                         Write(Html.ActionLink("Feedback", "Feedback", "Order"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 27, true);
            WriteLiteral("</button>\r\n    </p>\r\n</div>");
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
