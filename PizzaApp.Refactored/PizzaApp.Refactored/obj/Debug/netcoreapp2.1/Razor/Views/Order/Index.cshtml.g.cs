#pragma checksum "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0912da2864851a0ac7a1d03ccc8910c019125b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0912da2864851a0ac7a1d03ccc8910c019125b1", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db3745d783dfde69dbaf04201c970134901cde7", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Orders";

#line default
#line hidden
            BeginContext(68, 82, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h3>Fun facts</h3>\r\n    <p><b>First Customer: </b> ");
            EndContext();
            BeginContext(151, 25, false);
#line 9 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
                          Write(Model.NameOfFirstCustomer);

#line default
#line hidden
            EndContext();
            BeginContext(176, 41, true);
            WriteLiteral("</p>\r\n    <p><b>Last Pizza Ordered: </b> ");
            EndContext();
            BeginContext(218, 15, false);
#line 10 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
                              Write(Model.LastPizza);

#line default
#line hidden
            EndContext();
            BeginContext(233, 41, true);
            WriteLiteral("</p>\r\n    <p><b>Most popular Pizza: </b> ");
            EndContext();
            BeginContext(275, 22, false);
#line 11 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
                              Write(Model.MostPopularPizza);

#line default
#line hidden
            EndContext();
            BeginContext(297, 46, true);
            WriteLiteral("</p>\r\n    <p><b>Number of orders so far: </b> ");
            EndContext();
            BeginContext(344, 16, false);
#line 12 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
                                   Write(Model.OrderCount);

#line default
#line hidden
            EndContext();
            BeginContext(360, 117, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<h3 class=\"text-center text-primary\" style=\"font-size:xx-large\">All Orders</h3>\r\n\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
 foreach (var order in Model.Orders)
{
    

#line default
#line hidden
            BeginContext(523, 55, false);
#line 22 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
Write(Html.Partial("~/Views/Shared/_OrderItem.cshtml", order));

#line default
#line hidden
            EndContext();
#line 24 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
     foreach (var pizza in order.Pizzas)
    {
        

#line default
#line hidden
            BeginContext(640, 55, false);
#line 26 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
   Write(Html.Partial("~/Views/Shared/_PizzaItem.cshtml", pizza));

#line default
#line hidden
            EndContext();
#line 26 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
                                                                
    }

#line default
#line hidden
#line 27 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Order\Index.cshtml"
     
}

#line default
#line hidden
            BeginContext(707, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
