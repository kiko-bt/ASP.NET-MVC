#pragma checksum "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfd29a2001a5c88495bff8189c22389083438132"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\_ViewImports.cshtml"
using Class05.ViewsPart2;

#line default
#line hidden
#line 2 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\_ViewImports.cshtml"
using Class05.ViewsPart2.Models;

#line default
#line hidden
#line 3 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\_ViewImports.cshtml"
using Class05.ViewsPart2.Models.Domain;

#line default
#line hidden
#line 4 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\_ViewImports.cshtml"
using Class05.ViewsPart2.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd29a2001a5c88495bff8189c22389083438132", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55acc0db3abc46a3fe7556c040a8ecac02d2eafd", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(62, 30, true);
            WriteLiteral("\r\n<h2>All books</h2>\r\n<hr />\r\n");
            EndContext();
            BeginContext(92, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990ee9d4df8e4899b97e9908f6bc522e", async() => {
                BeginContext(137, 12, true);
                WriteLiteral("Add new book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(153, 256, true);
            WriteLiteral(@"
<br />
<br />

<table class=""table"">
    <thead>
        <tr>
            <th>#</th>
            <th>Title</th>
            <th>Genre</th>
            <th>Author</th>
            <th>Availability</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 24 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
         foreach (var book in Model)
        {
            string availability = book.IsAvailable ? "Available" : "Taken";

#line default
#line hidden
            BeginContext(535, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(574, 7, false);
#line 28 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(581, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(631, 68, false);
#line 30 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(Html.ActionLink(book.Title, "Details", "Book", new { id = book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(699, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(745, 10, false);
#line 32 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(book.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(755, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(783, 20, false);
#line 33 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(book.Author.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(803, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(853, 12, false);
#line 35 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(availability);

#line default
#line hidden
            EndContext();
            BeginContext(865, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(933, 53, false);
#line 38 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(986, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1054, 57, false);
#line 41 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 44 "D:\PRACTICE MAKE PERFECT\C#\ASP.NET MVC\Schoolwork\Class05.HTMLHelpersAndTags\Class05.ViewsPart2\Views\Book\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1166, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
