#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf35945ab7cd67cc29cb6f5a43f5b3e272cc264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Delete), @"mvc.1.0.view", @"/Views/Reviews/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Delete.cshtml", typeof(AspNetCore.Views_Reviews_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf35945ab7cd67cc29cb6f5a43f5b3e272cc264", @"/Views/Reviews/Delete.cshtml")]
    public class Views_Reviews_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(114, 47, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(161, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(164, 43, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(207, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(236, 41, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(376, 40, false);
#line 15 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Reviews/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
