#pragma checksum "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f89969c98d73645d6bb6eb43fb3918468e730a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PizzaItem), @"mvc.1.0.view", @"/Views/Shared/_PizzaItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PizzaItem.cshtml", typeof(AspNetCore.Views_Shared__PizzaItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f89969c98d73645d6bb6eb43fb3918468e730a3", @"/Views/Shared/_PizzaItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db3745d783dfde69dbaf04201c970134901cde7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PizzaItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Pizza Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 93, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\"></div>\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(116, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4aa18ca147684fba9092c4af097e0920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 126, "~/images/", 126, 9, true);
#line 7 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
AddHtmlAttributeValue("", 135, Model.Image, 135, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(182, 60, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h3>Pizza ");
            EndContext();
            BeginContext(243, 10, false);
#line 10 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 19, true);
            WriteLiteral("</h3>\r\n        <h4>");
            EndContext();
            BeginContext(273, 11, false);
#line 11 "C:\Users\Hristijan\Desktop\PizzaApp.Refactored\PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(284, 27, true);
            WriteLiteral(" $</h4>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
