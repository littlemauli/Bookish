#pragma checksum "C:\training\Bookish\Views\Book\searchOneBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a114c99671d5b154f8c1197c64885fb2ee1c518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_searchOneBook), @"mvc.1.0.view", @"/Views/Book/searchOneBook.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\training\Bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\training\Bookish\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a114c99671d5b154f8c1197c64885fb2ee1c518", @"/Views/Book/searchOneBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_searchOneBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookish.Models.BookListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <ol>\r\n");
#nullable restore
#line 7 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
      foreach (var book in @Model.BookList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 11 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
               Write(Html.DisplayFor(User => book.BookTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 14 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
               Write(Html.DisplayFor(User =>book.BookAuthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 17 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
               Write(Html.DisplayFor(User =>book.BookYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
#nullable restore
#line 20 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
               Write(Html.DisplayFor(User =>book.BookAvailableCopies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
#nullable restore
#line 23 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
               Write(Html.DisplayFor(User =>book.BookTotalCopies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 29 "C:\training\Bookish\Views\Book\searchOneBook.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ol>\r\n\r\n      \r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookish.Models.BookListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
