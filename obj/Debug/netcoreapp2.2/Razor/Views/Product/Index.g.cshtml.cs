#pragma checksum "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d836d6e9ae62927a80e8092e64b87edfc22711c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d836d6e9ae62927a80e8092e64b87edfc22711c", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03aed241bf4aa9e1f4b551307086dc0740987267", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StartMVC.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 44, true);
            WriteLiteral("\n<h1>Index</h1>\n<div>\n    <div class=\"row\">\n");
            EndContext();
#line 9 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
            BeginContext(388, 119, true);
            WriteLiteral("            <div class=\"col-md-4 col-sm-4 col-6 col-lg-4\">\n                <div class=\"card\" >\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 507, "\"", 527, 1);
#line 18 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
WriteAttributeValue("", 513, item.ImageUrl, 513, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 21, true);
            WriteLiteral(" class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 549, "\"", 565, 1);
#line 18 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
WriteAttributeValue("", 555, item.Name, 555, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(566, 93, true);
            WriteLiteral(">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(660, 9, false);
#line 20 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(669, 63, true);
            WriteLiteral("</h5>\n                        <p class=\"card-text text-danger\">");
            EndContext();
            BeginContext(733, 10, false);
#line 21 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(743, 29, true);
            WriteLiteral("</p>\n                        ");
            EndContext();
            BeginContext(772, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d836d6e9ae62927a80e8092e64b87edfc22711c6508", async() => {
                BeginContext(868, 8, true);
                WriteLiteral("Hemen Al");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(880, 70, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 26 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Product\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(961, 28, true);
            WriteLiteral("        </div>\n\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StartMVC.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
