#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d57ca9f168285ea178120fc3133297ddb78edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Delete), @"mvc.1.0.view", @"/Views/Restaurants/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Delete.cshtml", typeof(AspNetCore.Views_Restaurants_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d57ca9f168285ea178120fc3133297ddb78edf", @"/Views/Restaurants/Delete.cshtml")]
    public class Views_Restaurants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(118, 47, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(165, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(168, 43, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(211, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(240, 41, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(380, 40, false);
#line 15 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
