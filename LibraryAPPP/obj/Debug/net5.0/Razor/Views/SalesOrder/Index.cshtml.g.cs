#pragma checksum "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d40f2bfb7e7085e33dd430eed4b8a35fe9c196ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesOrder_Index), @"mvc.1.0.view", @"/Views/SalesOrder/Index.cshtml")]
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
#line 1 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\_ViewImports.cshtml"
using LibraryAPPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\_ViewImports.cshtml"
using LibraryAPPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d40f2bfb7e7085e33dd430eed4b8a35fe9c196ca", @"/Views/SalesOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b0adbdd86b5b949ed11cf35dce8b9a24496257", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LibraryAPPP.Models.ViewModels.BookViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
  
    var books = @Model;
    var searchQuery = Context.Request.Query["searchQuery"].ToString();
    var filteredBooks = string.IsNullOrWhiteSpace(searchQuery)
        ? books
        : books.Where(book =>
            book.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
            book.AuthorFirstName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)
            ).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex justify-content-between align-items-center\">\r\n    <h2 class=\"mb-3\">Sklep z książkami</h2>\r\n    <a class=\"btn btn-secondary\" href=\"/\">Strona główna</a>\r\n</div>\r\n<hr/>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d40f2bfb7e7085e33dd430eed4b8a35fe9c196ca4317", async() => {
                WriteLiteral("\r\n    <div class=\"input-group mb-3\">\r\n        <input type=\"text\" class=\"form-control\" name=\"searchQuery\" placeholder=\"Wyszukaj książkę lub autora...\"");
                BeginWriteAttribute("value", " value=\"", 836, "\"", 856, 1);
#nullable restore
#line 22 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 844, searchQuery, 844, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"input-group-append\">\r\n            <button class=\"btn btn-primary\" type=\"submit\">Szukaj</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>Autor</th>\r\n        <th>Tytuł</th>\r\n        <th>Data publikacji</th>\r\n        <th>Cena</th>\r\n        <th>Ilość</th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
     foreach (var book in filteredBooks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 44 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
           Write(book.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
                                 Write(book.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
           Write(book.PublicationDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
           Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
           Write(book.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1664, 4);
            WriteAttributeValue("", 1617, "/SalesOrder/BuyBook/", 1617, 20, true);
#nullable restore
#line 50 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 1637, book.ClientId, 1637, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1651, "/", 1651, 1, true);
#nullable restore
#line 50 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 1652, book.BookId, 1652, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1665, "\"", 1712, 5);
            WriteAttributeValue("", 1675, "buyBook(", 1675, 8, true);
#nullable restore
#line 50 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 1683, book.BookId, 1683, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1695, ",", 1695, 1, true);
#nullable restore
#line 50 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue(" ", 1696, book.ClientId, 1697, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1711, ")", 1711, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Kup</a>\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1802, "\"", 1858, 4);
            WriteAttributeValue("", 1809, "/SalesOrder/OrderBook/", 1809, 22, true);
#nullable restore
#line 53 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 1831, book.ClientId, 1831, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1845, "/", 1845, 1, true);
#nullable restore
#line 53 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 1846, book.BookId, 1846, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1859, "\"", 1908, 5);
            WriteAttributeValue("", 1869, "orderBook(", 1869, 10, true);
#nullable restore
#line 53 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue("", 1879, book.BookId, 1879, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1891, ",", 1891, 1, true);
#nullable restore
#line 53 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
WriteAttributeValue(" ", 1892, book.ClientId, 1893, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1907, ")", 1907, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Zamów</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\SalesOrder\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function goHome() {
            window.location.href = ""/"";
        }

        function buyBook(bookId, clientId) {
            window.location.href = $""/SalesOrder/BuyBook/"" + clientId + ""/"" + bookId;
        }
        
        function orderBook(bookId, clientId) {
            window.location.href = ""/SalesOrder/orderBook/"" + clientId + ""/"" + bookId;
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LibraryAPPP.Models.ViewModels.BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
