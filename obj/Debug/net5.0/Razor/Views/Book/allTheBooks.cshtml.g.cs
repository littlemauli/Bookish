#pragma checksum "C:\training\Bookish\Views\Book\allTheBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e0469a115814a544b9d0e33f19a1ba142c6ad5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_allTheBooks), @"mvc.1.0.view", @"/Views/Book/allTheBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e0469a115814a544b9d0e33f19a1ba142c6ad5e", @"/Views/Book/allTheBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_allTheBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\training\Bookish\Views\Book\allTheBooks.cshtml"
  
    ViewData["Title"] = "Book List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> All the books available </h1>\r\n   \r\n   <ol>\r\n");
#nullable restore
#line 10 "C:\training\Bookish\Views\Book\allTheBooks.cshtml"
         foreach (var item in @Model.BookList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 12 "C:\training\Bookish\Views\Book\allTheBooks.cshtml"
           Write(item.DisplayBook());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>           \r\n");
#nullable restore
#line 13 "C:\training\Bookish\Views\Book\allTheBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </ol>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
