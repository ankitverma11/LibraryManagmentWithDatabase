#pragma checksum "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fd397c6dca4fd65793e3e2f897ae1e4631f4a11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd397c6dca4fd65793e3e2f897ae1e4631f4a11", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578ca68f95fa192fbe39c38ac1fe69541ec89fa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagment.ViewModel.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Home\Index.cshtml"
  
    int availableBooks = Model.BookCount - Model.LendBookCount;

#line default
#line hidden
            BeginContext(123, 290, true);
            WriteLiteral(@"
<h1>Library managment dashboard</h1>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Customers Count
            </div>
            <div class=""panel-body"">
                There are ");
            EndContext();
            BeginContext(414, 19, false);
#line 16 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Home\Index.cshtml"
                     Write(Model.CustomerCount);

#line default
#line hidden
            EndContext();
            BeginContext(433, 288, true);
            WriteLiteral(@" customers.
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Authors Count
            </div>
            <div class=""panel-body"">
                There are ");
            EndContext();
            BeginContext(722, 17, false);
#line 26 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Home\Index.cshtml"
                     Write(Model.AuthorCount);

#line default
#line hidden
            EndContext();
            BeginContext(739, 284, true);
            WriteLiteral(@" Authors.
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Books Count
            </div>
            <div class=""panel-body"">
                There are ");
            EndContext();
            BeginContext(1024, 14, false);
#line 36 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Home\Index.cshtml"
                     Write(availableBooks);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 24, true);
            WriteLiteral(" books available out of ");
            EndContext();
            BeginContext(1063, 15, false);
#line 36 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Home\Index.cshtml"
                                                            Write(Model.BookCount);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 70, true);
            WriteLiteral(" Books.\r\n            </div>\r\n        </div>\r\n    </div>\r\n   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagment.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591