#pragma checksum "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Homework\ASP.NET-MVC\PizzaApp\SEDC.PizzaApp\Views\Order\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e683984351ca928489b687eb0759dae125d4fa87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetails), @"mvc.1.0.view", @"/Views/Order/OrderDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderDetails.cshtml", typeof(AspNetCore.Views_Order_OrderDetails))]
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
#line 1 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Homework\ASP.NET-MVC\PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#line 2 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Homework\ASP.NET-MVC\PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e683984351ca928489b687eb0759dae125d4fa87", @"/Views/Order/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<h2>OrderDetails</h2>\r\n<ul>\r\n");
            EndContext();
#line 3 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Homework\ASP.NET-MVC\PizzaApp\SEDC.PizzaApp\Views\Order\OrderDetails.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(70, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(83, 9, false);
#line 5 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Homework\ASP.NET-MVC\PizzaApp\SEDC.PizzaApp\Views\Order\OrderDetails.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(92, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 6 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Homework\ASP.NET-MVC\PizzaApp\SEDC.PizzaApp\Views\Order\OrderDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(106, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
