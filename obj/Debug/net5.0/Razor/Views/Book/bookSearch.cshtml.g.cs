#pragma checksum "C:\training\Bookish\Views\Book\bookSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f23644bfdeaf6e0385ab9b434a410af0ff11946c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_bookSearch), @"mvc.1.0.view", @"/Views/Book/bookSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23644bfdeaf6e0385ab9b434a410af0ff11946c", @"/Views/Book/bookSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_bookSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookish.Models.BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\training\Bookish\Views\Book\bookSearch.cshtml"
 using(Html.BeginForm("searchOneBookResult", "book", FormMethod.Get)) {  
    //the following are search options
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b> Search by Title of book </b>\r\n");
#nullable restore
#line 11 "C:\training\Bookish\Views\Book\bookSearch.cshtml"
Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type = \"submit\"  name = \"submit\" value = \"Search\"/>  \r\n");
#nullable restore
#line 12 "C:\training\Bookish\Views\Book\bookSearch.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookish.Models.BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591