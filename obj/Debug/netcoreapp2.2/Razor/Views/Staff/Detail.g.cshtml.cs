#pragma checksum "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf43363bc6c57800561be44199d9a32f73029c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Detail), @"mvc.1.0.view", @"/Views/Staff/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staff/Detail.cshtml", typeof(AspNetCore.Views_Staff_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf43363bc6c57800561be44199d9a32f73029c0", @"/Views/Staff/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03aed241bf4aa9e1f4b551307086dc0740987267", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StartMVC.Models.Staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
  
    ViewData["Title"] = "Personel Detail Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(135, 10, false);
#line 7 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(145, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(147, 14, false);
#line 7 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(161, 134, true);
            WriteLiteral("</h1>\n<div class=\"row mt-4 justify-content-center\">\n    <div class=\"card col-10 flex-md-row mb-4 box-shadow border-0\">\n\n        <image");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 295, "\"", 316, 1);
#line 11 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
WriteAttributeValue("", 301, Model.ImageUrl, 301, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(317, 382, true);
            WriteLiteral(@" class=""img-fluid"" style=""max-height:300px;""></image>
        <div class=""card-body d-flex flex-column align-items-start"">
            <table class=""table"">
                <tr>
                    <td class=""font-weight-bold text-right border-0"">
                        Ünvanı:
                    </td>
                    <td class=""text-left border-0"">
                        ");
            EndContext();
            BeginContext(700, 14, false);
#line 19 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
                   Write(Model.JobTitle);

#line default
#line hidden
            EndContext();
            BeginContext(714, 277, true);
            WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td class=""font-weight-bold text-right border-0"">
                        Cinsiyeti:
                    </td>
                    <td class=""text-left border-0"">
                        ");
            EndContext();
            BeginContext(993, 32, false);
#line 27 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
                    Write(Model.Gender ? "Kadın" : "Erkek");

#line default
#line hidden
            EndContext();
            BeginContext(1026, 286, true);
            WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td class=""font-weight-bold text-right border-0"">
                        İşe Başlama Tarihi:
                    </td>
                    <td class=""text-left border-0"">
                        ");
            EndContext();
            BeginContext(1313, 35, false);
#line 35 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
                   Write(Model.StartDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1348, 280, true);
            WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td class=""font-weight-bold text-right border-0"">
                        Doğum Tarihi:
                    </td>
                    <td class=""text-left border-0"">
                        ");
            EndContext();
            BeginContext(1629, 35, false);
#line 43 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
                   Write(Model.BirthDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1664, 273, true);
            WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td class=""font-weight-bold text-right border-0"">
                        Maaşı:
                    </td>
                    <td class=""text-left border-0"">
                        ");
            EndContext();
            BeginContext(1938, 12, false);
#line 51 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
                   Write(Model.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(1950, 277, true);
            WriteLiteral(@" TL
                    </td>
                </tr>
                <tr>
                    <td class=""font-weight-bold text-right border-0"">
                        Adresi:
                    </td>
                    <td class=""text-left border-0"">
                        ");
            EndContext();
            BeginContext(2228, 13, false);
#line 59 "C:\Users\mkg\Desktop\StartMVC\StartMVC\Views\Staff\Detail.cshtml"
                   Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2241, 82, true);
            WriteLiteral("\n                    </td>\n                </tr>\n            </table>\n            ");
            EndContext();
            BeginContext(2323, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf43363bc6c57800561be44199d9a32f73029c08815", async() => {
                BeginContext(2345, 11, true);
                WriteLiteral("Listeye Dön");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2360, 37, true);
            WriteLiteral("\n        </div>\n\n    </div>\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StartMVC.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591