#pragma checksum "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d0d00543ce40af58e1ddf4512e1fcf2d4db0b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_List), @"mvc.1.0.view", @"/Views/Customer/List.cshtml")]
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
#line 1 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d0d00543ce40af58e1ddf4512e1fcf2d4db0b8", @"/Views/Customer/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
  
    ViewData["Title"] = "Customer Manager";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Customer Manager</h3>\r\n<table>\r\n    <thead>\r\n        <tr>Name</tr>\r\n        <tr>Email</tr>\r\n        <tr>City</tr>\r\n        <tr></tr>\r\n        <tr></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
         foreach(Customer customer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
           Write(customer.customerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
           Write(customer.customerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
           Write(customer.customerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
           Write(customer.customerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>Temporary Edit</td>\r\n            <td>Temporary Delete</td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Customer\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
