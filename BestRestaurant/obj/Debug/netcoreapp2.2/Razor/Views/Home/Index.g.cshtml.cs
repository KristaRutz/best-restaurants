#pragma checksum "/Users/Guest/Desktop/best-restaurants/BestRestaurant/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829c20a1b93f840067a92cb17cf86605cfe53c3a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829c20a1b93f840067a92cb17cf86605cfe53c3a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/best-restaurants/BestRestaurant/Views/Home/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 74, true);
            WriteLiteral("\n<div id=\"homepage\">\n  <h1>Welcome to our Best Restaurant list!</h1>\n  <p>");
            EndContext();
            BeginContext(102, 56, false);
#line 7 "/Users/Guest/Desktop/best-restaurants/BestRestaurant/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all cuisines", "Index", "Cuisines"));

#line default
#line hidden
            EndContext();
            BeginContext(158, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(169, 62, false);
#line 8 "/Users/Guest/Desktop/best-restaurants/BestRestaurant/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all restaurants", "Index", "Restaurants"));

#line default
#line hidden
            EndContext();
            BeginContext(231, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(242, 62, false);
#line 9 "/Users/Guest/Desktop/best-restaurants/BestRestaurant/Views/Home/Index.cshtml"
Write(Html.ActionLink("Add new restaurant", "Create", "Restaurants"));

#line default
#line hidden
            EndContext();
            BeginContext(304, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(315, 56, false);
#line 10 "/Users/Guest/Desktop/best-restaurants/BestRestaurant/Views/Home/Index.cshtml"
Write(Html.ActionLink("Add new cuisine", "Create", "Cuisines"));

#line default
#line hidden
            EndContext();
            BeginContext(371, 11, true);
            WriteLiteral("</p>\n</div>");
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
