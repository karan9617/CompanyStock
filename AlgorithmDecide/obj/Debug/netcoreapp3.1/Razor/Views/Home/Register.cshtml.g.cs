#pragma checksum "/Users/karanvishwakarma/Projects/AlgorithmDecide/AlgorithmDecide/Views/Home/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f1f28b5502a863ae9071ad9fad9593ed06a5c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "/Users/karanvishwakarma/Projects/AlgorithmDecide/AlgorithmDecide/Views/_ViewImports.cshtml"
using AlgorithmDecide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/karanvishwakarma/Projects/AlgorithmDecide/AlgorithmDecide/Views/_ViewImports.cshtml"
using AlgorithmDecide.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f1f28b5502a863ae9071ad9fad9593ed06a5c2", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c22cbe1bf60bf23defd657f1e72b8c835be0e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/karanvishwakarma/Projects/AlgorithmDecide/AlgorithmDecide/Views/Home/Register.cshtml"
  
    Layout = "../Shared/_LayoutForMainPage.cshtml";
    ViewData["title"] = "Register Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Register component</h2>\n");
#nullable restore
#line 7 "/Users/karanvishwakarma/Projects/AlgorithmDecide/AlgorithmDecide/Views/Home/Register.cshtml"
 using (Html.BeginForm("Register", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>First name</p><input type=\"text\" name=\"firstName\" />\n");
            WriteLiteral("<br />\n<p>lastName</p><input type=\"text\" name=\"lastName\" />\n");
            WriteLiteral("<br />\n");
            WriteLiteral("<p>Address</p><input type=\"text\" name=\"address\" />\n");
            WriteLiteral("<br />\n");
            WriteLiteral("<p>Salary</p><input type=\"text\" name=\"salary\" />\n");
            WriteLiteral("<br />\n");
            WriteLiteral("<input type=\"submit\" value=\"REGISTER\" />\n");
            WriteLiteral("<br />\n");
#nullable restore
#line 27 "/Users/karanvishwakarma/Projects/AlgorithmDecide/AlgorithmDecide/Views/Home/Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591