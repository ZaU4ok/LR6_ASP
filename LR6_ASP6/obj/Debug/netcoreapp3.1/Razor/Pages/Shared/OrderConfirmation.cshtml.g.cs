#pragma checksum "C:\Users\SuperPC\source\repos\LR6_ASP6\LR6_ASP6\Pages\Shared\OrderConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "023a362d87867fdf0de50516d0b00b71805c9fe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LR6_ASP6.Pages.Shared.Pages_Shared_OrderConfirmation), @"mvc.1.0.view", @"/Pages/Shared/OrderConfirmation.cshtml")]
namespace LR6_ASP6.Pages.Shared
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
#line 1 "C:\Users\SuperPC\source\repos\LR6_ASP6\LR6_ASP6\Pages\_ViewImports.cshtml"
using LR6_ASP6;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023a362d87867fdf0de50516d0b00b71805c9fe8", @"/Pages/Shared/OrderConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e8cfcc91dec83e5b6a246942845310506eec45", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_OrderConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LR6_ASP6.Model.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Ordered Products:</h2>\r\n<ul>\r\n");
#nullable restore
#line 5 "C:\Users\SuperPC\source\repos\LR6_ASP6\LR6_ASP6\Pages\Shared\OrderConfirmation.cshtml"
     foreach (var product in ViewBag.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 7 "C:\Users\SuperPC\source\repos\LR6_ASP6\LR6_ASP6\Pages\Shared\OrderConfirmation.cshtml"
       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\SuperPC\source\repos\LR6_ASP6\LR6_ASP6\Pages\Shared\OrderConfirmation.cshtml"
                       Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" units</li>\r\n");
#nullable restore
#line 8 "C:\Users\SuperPC\source\repos\LR6_ASP6\LR6_ASP6\Pages\Shared\OrderConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LR6_ASP6.Model.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
