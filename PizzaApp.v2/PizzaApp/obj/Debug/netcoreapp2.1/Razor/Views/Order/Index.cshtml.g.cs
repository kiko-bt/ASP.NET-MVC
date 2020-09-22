#pragma checksum "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d472b79b6e7a339c20af028c9146cc284a2d0e8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d472b79b6e7a339c20af028c9146cc284a2d0e8", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fada01253373a4c11a49a1506b9f80f3d288ed94", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 254, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"text-center page-header\">Welcome To The Order Page</h1>\r\n\r\n\r\n    <br />\r\n\r\n\r\n\r\n    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered table-condensed table-striped table-hover sortable\">\r\n");
            EndContext();
#line 13 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
             foreach (var order in Model.Orders)
            {

#line default
#line hidden
            BeginContext(346, 378, true);
            WriteLiteral(@"                <thead style=""color: bisque"">
                    <tr>
                        <th>Order no.</th>
                        <th>Customer Name</th>
                        <th>Pizza</th>
                        <th>Price</th>
                        <th>Image</th>
                        <th>About</th>
                    </tr>
                </thead>
");
            EndContext();
            BeginContext(726, 79, true);
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(806, 8, false);
#line 28 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                       Write(order.ID);

#line default
#line hidden
            EndContext();
            BeginContext(814, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(850, 20, false);
#line 29 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                       Write(order.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(870, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(872, 19, false);
#line 29 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                                             Write(order.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(891, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(927, 16, false);
#line 30 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                       Write(order.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(943, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(979, 11, false);
#line 31 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                       Write(order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(990, 181, true);
            WriteLiteral("</td>\r\n                        <td><img src=\"https://www.cicis.com/wp-content/uploads/2019/04/pizza_categoryheader.png\" alt=\"Pizza\" height=\"30\" /></td>\r\n                        <td>");
            EndContext();
            BeginContext(1172, 69, false);
#line 33 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", "Order", new { id = order.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 60, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n");
            EndContext();
#line 36 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1316, 160, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n\r\n\r\n    <div class=\"text-center\">\r\n        <h3>Our first Pizza ever to be delivered  was:</h3>\r\n        <p style=\"color:bisque\">");
            EndContext();
            BeginContext(1477, 16, false);
#line 44 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                           Write(Model.FirstPizza);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 84, true);
            WriteLiteral("</p>\r\n\r\n\r\n        <h3>Our first customer was:</h3>\r\n        <p style=\"color:bisque\">");
            EndContext();
            BeginContext(1578, 23, false);
#line 48 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                           Write(Model.FirstCustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 102, true);
            WriteLiteral("</p>\r\n\r\n\r\n        <h3>Total orders since we started delivering:</h3>\r\n        <p style=\"color:bisque\">");
            EndContext();
            BeginContext(1704, 20, false);
#line 52 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\PizzaApp\PizzaApp\Views\Order\Index.cshtml"
                           Write(Model.NumberOfOrders);

#line default
#line hidden
            EndContext();
            BeginContext(1724, 30, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591