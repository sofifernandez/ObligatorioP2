#pragma checksum "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234678a5fa78e6d83c8f438d4bef34cb2f5c8bef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resenia_VerReseniasPersonales), @"mvc.1.0.view", @"/Views/Resenia/VerReseniasPersonales.cshtml")]
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
#line 1 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234678a5fa78e6d83c8f438d4bef34cb2f5c8bef", @"/Views/Resenia/VerReseniasPersonales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c816bb28de69d7646d9da673eaff207aa081", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Resenia_VerReseniasPersonales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 2 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
Write(ViewBag.Periodista.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 2 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
                          Write(ViewBag.Periodista.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h2>Reseñas propias</h2>\r\n<div>\r\n");
#nullable restore
#line 6 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
     if (ViewBag.Resenias.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
         foreach (Reseña item in ViewBag.Resenias)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"margin-bottom: 30px\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
                                      Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
                                    Write(item.PartidoRes.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
                                    Write(item.PartidoRes.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
                                    Write(item.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
               }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>Aún no tienes reseñas</div>\r\n");
#nullable restore
#line 22 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Resenia\VerReseniasPersonales.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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