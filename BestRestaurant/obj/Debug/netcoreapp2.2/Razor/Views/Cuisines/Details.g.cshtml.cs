#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120e5f0510e018cc712aa45d34ba4e0e9d1b2af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Details), @"mvc.1.0.view", @"/Views/Cuisines/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Details.cshtml", typeof(AspNetCore.Views_Cuisines_Details))]
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
#line 5 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
using BestRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120e5f0510e018cc712aa45d34ba4e0e9d1b2af9", @"/Views/Cuisines/Details.cshtml")]
    public class Views_Cuisines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(96, 37, true);
            WriteLiteral("\n<h2>Cuisine Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(134, 40, false);
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(174, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(177, 36, false);
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(213, 12, true);
            WriteLiteral("</h3>\n\n<ul>\n");
            EndContext();
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
 if (@Model.Restaurants.Count == 0)
{

#line default
#line hidden
            BeginContext(263, 30, true);
            WriteLiteral("  <p>no restaurants found</p>\n");
            EndContext();
#line 16 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
}

#line default
#line hidden
            BeginContext(295, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
 foreach (Restaurant restaurant in @Model.Restaurants)
{

#line default
#line hidden
            BeginContext(353, 19, true);
            WriteLiteral("  <li>Description: ");
            EndContext();
            BeginContext(373, 22, false);
#line 20 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
              Write(restaurant.Description);

#line default
#line hidden
            EndContext();
            BeginContext(395, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
}

#line default
#line hidden
            BeginContext(403, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(414, 44, false);
#line 24 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
Write(Html.ActionLink("Back to cuisines", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(458, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(467, 69, false);
#line 25 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
Write(Html.ActionLink("Edit Cuisine", "Edit", new { id = Model.CuisineId }));

#line default
#line hidden
            EndContext();
            BeginContext(536, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(545, 73, false);
#line 26 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Details.cshtml"
Write(Html.ActionLink("Delete Cuisine", "Delete", new { id = Model.CuisineId }));

#line default
#line hidden
            EndContext();
            BeginContext(618, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
