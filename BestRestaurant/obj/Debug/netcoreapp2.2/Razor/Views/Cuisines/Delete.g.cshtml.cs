#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9dfc773ffbd33aaa27cb4e76e5d4e44c0d4fcc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Delete), @"mvc.1.0.view", @"/Views/Cuisines/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Delete.cshtml", typeof(AspNetCore.Views_Cuisines_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9dfc773ffbd33aaa27cb4e76e5d4e44c0d4fcc6", @"/Views/Cuisines/Delete.cshtml")]
    public class Views_Cuisines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(65, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(115, 40, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(155, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(158, 36, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(194, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(223, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(269, 44, false);
#line 14 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Delete.cshtml"
Write(Html.ActionLink("Back to cuisines", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
