#pragma checksum "F:\ASPNET_Core_BITM9\Projects\App01_Intro\App01_Intro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5419ecbfa5013e819c3ddb0b0ad679f5ceffc1a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\ASPNET_Core_BITM9\Projects\App01_Intro\App01_Intro\Views\_ViewImports.cshtml"
using App01_Intro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASPNET_Core_BITM9\Projects\App01_Intro\App01_Intro\Views\_ViewImports.cshtml"
using App01_Intro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5419ecbfa5013e819c3ddb0b0ad679f5ceffc1a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3716effe7a3d330082c7b0384ad212797beb11", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\ASPNET_Core_BITM9\Projects\App01_Intro\App01_Intro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <input type=\"text\" id=\"mytext\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 129, "\"", 137, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <button id=\"btntext\" class=\"btn btn-success\">Show My Text</button>\r\n    <h1 id=\"wcmsg\" class=\"display-4\">Welcome to ASP.NET Core MVC Course</h1>\r\n    <h2 id=\"msg\" class=\"alert alert-info\">A lot of exciting things awaits for you</h2>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $(document).ready(function () {
        $(""#btntext"").click(function () {
            var m = $(""#mytext"").val();
            $(""#wcmsg"").html(m);
            $(""#wcmsg"").hide();
            $(""#wcmsg"").fadeIn(5000);
            $(""#msg"").show();
            $(""#msg"").fadeOut(5000);
        });

    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
