#pragma checksum "C:\Users\vgavva\source\repos\DemoPartialView\DemoPartialView\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383c6e5d01a9d0651e09be53234e8145171b852d"
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
#line 1 "C:\Users\vgavva\source\repos\DemoPartialView\DemoPartialView\Views\_ViewImports.cshtml"
using DemoPartialView;

#line default
#line hidden
#line 2 "C:\Users\vgavva\source\repos\DemoPartialView\DemoPartialView\Views\_ViewImports.cshtml"
using DemoPartialView.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"383c6e5d01a9d0651e09be53234e8145171b852d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b627825825d86bb727ee8de6305cbd11cb0a47c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vgavva\source\repos\DemoPartialView\DemoPartialView\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 501, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div id=""partialgoeshere""></div>
    <a id=""myLink"">Open Popup</a>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<button id='showGame'>Show Game Listing</button>
<script type=""text/javascript"">

    $(document ).ready(function() {

        $(""#myLink"").click(function () {
            {
                alert(""sss"");
                $.get(""");
            EndContext();
            BeginContext(547, 28, false);
#line 20 "C:\Users\vgavva\source\repos\DemoPartialView\DemoPartialView\Views\Home\Index.cshtml"
                  Write(Url.Action("ShowNamesPopup"));

#line default
#line hidden
            EndContext();
            BeginContext(575, 206, true);
            WriteLiteral("\", function (data) {\r\n                    $(\"#partialgoeshere\").empty();\r\n                    $(\"#partialgoeshere\").html(data);\r\n\r\n                });\r\n            }\r\n        });\r\n\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
