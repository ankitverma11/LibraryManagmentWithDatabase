#pragma checksum "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "440b1ee7597578fe79f7d95372ddeed546308c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Return_List), @"mvc.1.0.view", @"/Views/Return/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Return/List.cshtml", typeof(AspNetCore.Views_Return_List))]
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
#line 1 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
using LibraryManagment.Data.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"440b1ee7597578fe79f7d95372ddeed546308c05", @"/Views/Return/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578ca68f95fa192fbe39c38ac1fe69541ec89fa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Return_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Return", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnABook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 281, true);
            WriteLiteral(@"
<table class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th> ID </th>
            <th> Name </th>
            <th> Author Name </th>
            <th> Borrower Name </th>
            <th> Return </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
            BeginContext(394, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(425, 11, false);
#line 19 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
           Write(book.BookId);

#line default
#line hidden
            EndContext();
            BeginContext(436, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(460, 10, false);
#line 20 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
           Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(470, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(494, 16, false);
#line 21 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
           Write(book.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(510, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(534, 19, false);
#line 22 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
           Write(book.Borrowner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(553, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(576, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3369e2b4b1e34a1d8fb2ca8a2364ecc5", async() => {
                BeginContext(680, 6, true);
                WriteLiteral("Return");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
                                                                                              WriteLiteral(book.BookId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(690, 23, true);
            WriteLiteral(" </td>\r\n        </tr>\r\n");
            EndContext();
#line 25 "E:\Ankit\LibraryManagmentWithDataBase\LibraryManagment\Views\Return\List.cshtml"
        }

#line default
#line hidden
            BeginContext(724, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
