#pragma checksum "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_OrderItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "428dabaa587ca2b3e246d1a8d25aa118f66f5064"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderItem), @"mvc.1.0.view", @"/Views/Shared/_OrderItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OrderItem.cshtml", typeof(AspNetCore.Views_Shared__OrderItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428dabaa587ca2b3e246d1a8d25aa118f66f5064", @"/Views/Shared/_OrderItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fada01253373a4c11a49a1506b9f80f3d288ed94", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 18, true);
            WriteLiteral("\r\n\r\n<h3>Order no. ");
            EndContext();
            BeginContext(33, 8, false);
#line 4 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_OrderItem.cshtml"
         Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(41, 16, true);
            WriteLiteral("</h3>\r\n<p>Name: ");
            EndContext();
            BeginContext(58, 20, false);
#line 5 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_OrderItem.cshtml"
    Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(78, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(81, 19, false);
#line 5 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_OrderItem.cshtml"
                           Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(100, 16, true);
            WriteLiteral("</p>\r\n<p>Pizza: ");
            EndContext();
            BeginContext(117, 16, false);
#line 6 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_OrderItem.cshtml"
     Write(Model.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(133, 16, true);
            WriteLiteral("</p>\r\n<p>Price: ");
            EndContext();
            BeginContext(150, 11, false);
#line 7 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Shared\_OrderItem.cshtml"
     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(161, 117, true);
            WriteLiteral("</p>\r\n<img src=\"https://www.cicis.com/wp-content/uploads/2019/04/pizza_categoryheader.png\" alt=\"Pizza\" height=\"50\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591