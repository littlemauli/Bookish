#pragma checksum "C:\training\Bookish\Views\Home\ShowMemberCommand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e2b5989ed30c21e43928110fda7409aba5c75d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowMemberCommand), @"mvc.1.0.view", @"/Views/Home/ShowMemberCommand.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e2b5989ed30c21e43928110fda7409aba5c75d", @"/Views/Home/ShowMemberCommand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowMemberCommand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\training\Bookish\Views\Home\ShowMemberCommand.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link");
            BeginWriteAttribute("href", " href=\"", 52, "\"", 90, 1);
#nullable restore
#line 5 "C:\training\Bookish\Views\Home\ShowMemberCommand.cshtml"
WriteAttributeValue("", 59, Url.Content("~/css/index.css"), 59, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" rel=""stylesheet"" type=""text/css"" />

<div class=""text-center"">
    <h3 class=""display-4""> Dear Member, welcome to the library!</h3>

<p>Please Select what you would like to do:</p>
<button type=""submit"" class=""xx"" onclick=""window.location.href='https://localhost:5001/book/allTheBooks';""> Display
        all available books</button>
<button type=""submit"" class=""xx"" onclick=""window.location.href='https://localhost:5001/library/privacy';""> View our
        privacy conditions</button>
<button type=""submit"" class=""xx"" onclick=""window.location.href='https://localhost:5001/book/bookSearch';""> Search
        for a book by Title</button>");
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
