#pragma checksum "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed8a78bd5b9b717c7329569a5a78f8df05ee3d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerEstadisticas), @"mvc.1.0.view", @"/Views/Home/VerEstadisticas.cshtml")]
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
#line 1 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\_ViewImports.cshtml"
using Obligatorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\_ViewImports.cshtml"
using Obligatorio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed8a78bd5b9b717c7329569a5a78f8df05ee3d0", @"/Views/Home/VerEstadisticas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c816bb28de69d7646d9da673eaff207aa081", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_VerEstadisticas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Estadísticas</h1>\r\n<div>\r\n    <h2> Reseñas de partidos con rojas</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aed8a78bd5b9b717c7329569a5a78f8df05ee3d04005", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"email\">Email de periodista</label>\r\n            <input type=\"text\" name=\"email\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 278, "\"", 300, 1);
#nullable restore
#line 9 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
WriteAttributeValue("", 286, ViewBag.Email, 286, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Ver</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
     if (ViewBag.Partidos != null)
    {
        foreach (Partido item in ViewBag.Partidos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card text-center my-3 col-6\">\r\n                <div class=\"card-header\">\r\n                    <h5 class=\"card-title bg-dark text-white\">");
#nullable restore
#line 19 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
                                                         Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 19 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
                                                                                         Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"card-body\">\r\n\r\n                    <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
                                    Write(item.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"card-footer text-muted\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
               Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    <h2>Selección/es con más goles: ");
#nullable restore
#line 34 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
                               Write(ViewBag.MasGoles);

#line default
#line hidden
#nullable disable
            WriteLiteral(" goles</h2>\r\n    <div>\r\n");
#nullable restore
#line 36 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
         foreach (Seleccion item in ViewBag.SeleccionMasGoles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 38 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
            Write(item.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 39 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Home\VerEstadisticas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
