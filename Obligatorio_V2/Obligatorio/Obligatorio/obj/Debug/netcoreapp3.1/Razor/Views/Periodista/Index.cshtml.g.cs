#pragma checksum "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Periodista\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b036f8fccc7f01fcbdac3224d3757a4ae261dbde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Periodista_Index), @"mvc.1.0.view", @"/Views/Periodista/Index.cshtml")]
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
#line 1 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\_ViewImports.cshtml"
using Obligatorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\_ViewImports.cshtml"
using Obligatorio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Periodista\Index.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b036f8fccc7f01fcbdac3224d3757a4ae261dbde", @"/Views/Periodista/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c816bb28de69d7646d9da673eaff207aa081", @"/Views/_ViewImports.cshtml")]
    public class Views_Periodista_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Periodista</h1>\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Periodista\Index.cshtml"
 foreach (Periodista item in ViewBag.Periodistas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 8 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Periodista\Index.cshtml"
  Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Periodista\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
