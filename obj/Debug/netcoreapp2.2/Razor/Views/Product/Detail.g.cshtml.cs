#pragma checksum "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a3122034ecb98e6e2f368c42ea8b2f58932c5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Detail.cshtml", typeof(AspNetCore.Views_Product_Detail))]
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
#line 1 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\_ViewImports.cshtml"
using StartMVC;

#line default
#line hidden
#line 2 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\_ViewImports.cshtml"
using StartMVC.Models;

#line default
#line hidden
#line 3 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\_ViewImports.cshtml"
using StartMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a3122034ecb98e6e2f368c42ea8b2f58932c5b", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03aed241bf4aa9e1f4b551307086dc0740987267", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StartMVC.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(72, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(78, 10, false);
#line 6 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Detail.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(88, 12, true);
            WriteLiteral("</h1>\n<image");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 100, "\"", 121, 1);
#line 7 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Detail.cshtml"
WriteAttributeValue("", 106, Model.ImageUrl, 106, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(122, 51, true);
            WriteLiteral(" class=\"img-fluid\"></image>\n<p class=\"text-danger\">");
            EndContext();
            BeginContext(174, 11, false);
#line 8 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Detail.cshtml"
                  Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(185, 6, true);
            WriteLiteral("</p>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StartMVC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
