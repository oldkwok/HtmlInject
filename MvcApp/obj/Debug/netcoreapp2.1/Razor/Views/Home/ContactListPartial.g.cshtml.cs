#pragma checksum "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8617122cf0ede80fb013bed867c898422d6eff94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactListPartial), @"mvc.1.0.view", @"/Views/Home/ContactListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactListPartial.cshtml", typeof(AspNetCore.Views_Home_ContactListPartial))]
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
#line 1 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\_ViewImports.cshtml"
using MvcApp;

#line default
#line hidden
#line 2 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\_ViewImports.cshtml"
using MvcApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8617122cf0ede80fb013bed867c898422d6eff94", @"/Views/Home/ContactListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df07ef8027e49ca862b2c679628b74db7e0ce96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 281, true);
            WriteLiteral(@"
<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email Address</th>
            <th>Phone No.</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 14 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
         foreach (var contact in Model)
        {

#line default
#line hidden
            BeginContext(362, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(401, 135, false);
#line 17 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
               Write(Ajax.ActionLink(contact.Id, "Update", new { contactId = contact.Id }, new AjaxOptions { OnSuccess = "showDialog", HttpMethod = "GET" }));

#line default
#line hidden
            EndContext();
            BeginContext(536, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(564, 17, false);
#line 18 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
               Write(contact.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(581, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(609, 16, false);
#line 19 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
               Write(contact.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(625, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(653, 20, false);
#line 20 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
               Write(contact.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(673, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(701, 15, false);
#line 21 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
               Write(contact.PhoneNo);

#line default
#line hidden
            EndContext();
            BeginContext(716, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 23 "D:\Visual Studio\VS2017\VSCode\HtmlInject\MvcApp\Views\Home\ContactListPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(753, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591