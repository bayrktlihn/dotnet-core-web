#pragma checksum "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce32f6b2ce4fbb3b1b3dc4be5b900638fdc2b2c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce32f6b2ce4fbb3b1b3dc4be5b900638fdc2b2c5", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e70f579315d5fc387a45da13a70a4a9ab55da0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count > 2 ? "popular" : "";
    var products = Model.Products;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
 if (@products.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"alert alert-danger\">\r\n                ");
#nullable restore
#line 21 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n    \r\n");
#nullable restore
#line 29 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
               Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </div>                      \r\n");
#nullable restore
#line 34 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\bayrktlihn\Desktop\shopapp.webui\Views\Product\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
