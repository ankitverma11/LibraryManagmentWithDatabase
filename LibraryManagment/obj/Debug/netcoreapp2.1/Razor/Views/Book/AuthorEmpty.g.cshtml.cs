#pragma checksum "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Book\AuthorEmpty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d5bc1ab03941de39a6b37a78e6f949f24874fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_AuthorEmpty), @"mvc.1.0.view", @"/Views/Book/AuthorEmpty.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/AuthorEmpty.cshtml", typeof(AspNetCore.Views_Book_AuthorEmpty))]
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
#line 1 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\_ViewImports.cshtml"
using LibraryManagment;

#line default
#line hidden
#line 2 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\_ViewImports.cshtml"
using LibraryManagment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d5bc1ab03941de39a6b37a78e6f949f24874fb", @"/Views/Book/AuthorEmpty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578ca68f95fa192fbe39c38ac1fe69541ec89fa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_AuthorEmpty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagment.Data.Model.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 13, true);
            WriteLiteral("\r\n<h2>Author ");
            EndContext();
            BeginContext(57, 10, false);
#line 3 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Book\AuthorEmpty.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(67, 23, true);
            WriteLiteral(" has no books.</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagment.Data.Model.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
