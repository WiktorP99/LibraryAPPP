#pragma checksum "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4315da941f60b253a08a0d8103c423d2208b39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ClientDetailsView), @"mvc.1.0.view", @"/Views/Client/ClientDetailsView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4315da941f60b253a08a0d8103c423d2208b39", @"/Views/Client/ClientDetailsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b0adbdd86b5b949ed11cf35dce8b9a24496257", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_ClientDetailsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryAPPP.DB.DTO.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""d-flex justify-content-between align-items-center"">
    <button class=""btn btn-primary mb-3"" onclick=""goBack()"">Powrót</button>
</div>
<br/>
<div>
    <h3 class=""m-0"">Informacje o kliencie</h3>
</div>
<br/>

<div class=""card"">
    <div class=""card-body"">
        <h5 class=""card-title"">");
#nullable restore
#line 14 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                          Write(Model.ClientFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                 Write(Model.ClientLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <ul class=\"list-group list-group-flush\">\r\n            <li class=\"list-group-item\"><strong>Identyfikator klienta:</strong> ");
#nullable restore
#line 16 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                                           Write(Model.ClientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><strong>Email:</strong> ");
#nullable restore
#line 17 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><strong>Adres:</strong> ");
#nullable restore
#line 18 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><strong>Miasto:</strong> ");
#nullable restore
#line 19 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                            Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><strong>Województwo:</strong> ");
#nullable restore
#line 20 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                                 Write(Model.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><strong>Kod pocztowy:</strong> ");
#nullable restore
#line 21 "D:\HOBBY\LibraryAPPP\LibraryAPPP\Views\Client\ClientDetailsView.cshtml"
                                                                  Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function goBack() {\r\n            window.location.href = \"/\";\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryAPPP.DB.DTO.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
