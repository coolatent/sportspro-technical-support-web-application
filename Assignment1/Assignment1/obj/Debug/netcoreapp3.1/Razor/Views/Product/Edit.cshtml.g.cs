#pragma checksum "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b90a0afef75c96efdc6696d3c964519f841d9902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b90a0afef75c96efdc6696d3c964519f841d9902", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
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
            WriteLiteral("<h3>");
#nullable restore
#line 2 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
Write(ViewBag.Action);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Product</h3>\r\n\r\n");
#nullable restore
#line 4 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
 if (ViewBag.Action == "Add")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b90a0afef75c96efdc6696d3c964519f841d99023803", async() => {
                WriteLiteral(@"
        <label for=""productCode"">Code</label>
        <br />
        <input type=""text"" id=""productCode"" name=""productCode"" />
        <br />
        <label for=""productName"">Name</label>
        <br />
        <input type=""text"" id=""productName"" name=""productName"" />
        <br />
        <label for=""productPrice"">Yearly Price</label>
        <br />
        <input type=""text"" id=""productPrice"" name=""productPrice"" />
        <br />
        <label for=""productReleaseDate"">Release Date</label>
        <br />
        <input type=""text"" id=""productReleaseDate"" name=""productReleaseDate""");
                BeginWriteAttribute("value", " value=\"", 701, "\"", 722, 1);
#nullable restore
#line 21 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
WriteAttributeValue("", 709, DateTime.Now, 709, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br /><br />\r\n        <button type=\"submit\">Save</button>\r\n        <button type=\"submit\">Cancel</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
 if (ViewBag.Action == "Edit")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"productCode\">Code</label>\r\n    <br />\r\n    <input type=\"text\" id=\"productCode\" name=\"productCode\"");
            BeginWriteAttribute("value", " value=\"", 1006, "\"", 1058, 1);
#nullable restore
#line 31 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1014, Html.DisplayFor(model => model.productCode), 1014, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    <label for=\"productName\">Name</label>\r\n    <br />\r\n    <input type=\"text\" id=\"productName\" name=\"productName\"");
            BeginWriteAttribute("value", " value=\"", 1189, "\"", 1241, 1);
#nullable restore
#line 35 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1197, Html.DisplayFor(model => model.productName), 1197, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    <label for=\"productPrice\">Yearly Price</label>\r\n    <br />\r\n    <input type=\"text\" id=\"productPrice\" name=\"productPrice\"");
            BeginWriteAttribute("value", " value=\"", 1383, "\"", 1436, 1);
#nullable restore
#line 39 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1391, Html.DisplayFor(model => model.productPrice), 1391, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    <label for=\"productReleaseDate\">Release Date</label>\r\n    <br />\r\n    <input type=\"text\" id=\"productReleaseDate\" name=\"productReleaseDate\"");
            BeginWriteAttribute("value", " value=\"", 1596, "\"", 1655, 1);
#nullable restore
#line 43 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1604, Html.DisplayFor(model => model.productReleaseDate), 1604, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    <br />\r\n    <button type=\"submit\">Save</button>\r\n    <button type=\"submit\">Cancel</button>\r\n");
#nullable restore
#line 48 "D:\School\Semester 4\COMP2139\Assignment\Assignment1\Assignment1\Assignment1\Views\Product\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
