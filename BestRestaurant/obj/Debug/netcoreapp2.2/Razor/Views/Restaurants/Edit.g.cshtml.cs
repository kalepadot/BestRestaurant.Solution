#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624ed1c80fe4b8f814cf415b9f16b91d81f336e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Edit), @"mvc.1.0.view", @"/Views/Restaurants/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Edit.cshtml", typeof(AspNetCore.Views_Restaurants_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"624ed1c80fe4b8f814cf415b9f16b91d81f336e8", @"/Views/Restaurants/Edit.cshtml")]
    public class Views_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 36, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
            EndContext();
            BeginContext(105, 43, false);
#line 9 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(148, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(188, 43, false);
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
Write(Html.HiddenFor(model => model.RestaurantId));

#line default
#line hidden
            EndContext();
            BeginContext(238, 41, false);
#line 15 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(285, 42, false);
#line 16 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(334, 37, false);
#line 18 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(377, 30, false);
#line 19 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
            EndContext();
            BeginContext(409, 46, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />     \n");
            EndContext();
#line 22 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(457, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(461, 40, false);
#line 23 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(501, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
