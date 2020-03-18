#pragma checksum "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c6ffaeee7acadfc26035a058ff4a474f97bc082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
#line 5 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
using ProjectName.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6ffaeee7acadfc26035a058ff4a474f97bc082", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjectName.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(97, 22, true);
            WriteLiteral("\n<h1>Categories</h1>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(145, 41, true);
            WriteLiteral("  <h3>No items have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(189, 6, true);
            WriteLiteral("\n<ul>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
   foreach (Category category in Model)
  {

#line default
#line hidden
            BeginContext(239, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(248, 80, false);
#line 18 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
   Write(Html.ActionLink($"{category.Name}", "Details", new { id = category.CategoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(328, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(338, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(349, 45, false);
#line 22 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
Write(Html.ActionLink("Add new category", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(394, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(403, 40, false);
#line 23 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(443, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjectName.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591