#pragma checksum "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8446b9e19b6966c741ead317a13313ee22cec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partido_VerPartidos), @"mvc.1.0.view", @"/Views/Partido/VerPartidos.cshtml")]
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
#line 1 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8446b9e19b6966c741ead317a13313ee22cec5", @"/Views/Partido/VerPartidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c816bb28de69d7646d9da673eaff207aa081", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Partido_VerPartidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Partidos</h1>\r\n<div>\r\n    <h2>Partidos Fase de Grupos</h2>\r\n    <div>\r\n        <h3>Finalizados</h3>\r\n");
#nullable restore
#line 13 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         foreach (Partido item in ViewBag.PartidosGrupo)
        {
            if (item.Finalizado)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mt-4\">\r\n                    <h3>");
#nullable restore
#line 18 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                   Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 18 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                   Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 19 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                  Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 20 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr />\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div>\r\n        <h3>Por finalizar</h3>\r\n");
#nullable restore
#line 29 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         foreach (Partido item in ViewBag.PartidosGrupo)
        {
                if (!item.Finalizado)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mt-4\">\r\n                        <h3>");
#nullable restore
#line 34 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                       Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 34 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                       Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 35 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                      Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button class=\"btn-info\"><a");
            BeginWriteAttribute("href", " href=\"", 1129, "\"", 1180, 2);
            WriteAttributeValue("", 1136, "/Partido/FinalizarPartido?id=", 1136, 29, true);
#nullable restore
#line 36 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
WriteAttributeValue("", 1165, item.IDPartido, 1165, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Finalizar</a></button>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    <h2>Partidos Fase Eliminatorias</h2>\r\n    <div>\r\n        <h3>Finalizados</h3>\r\n");
#nullable restore
#line 48 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         foreach (Partido item in ViewBag.PartidosEliminatoria)
        {
            if (item.Finalizado)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mt-4\">\r\n                    <h3>");
#nullable restore
#line 53 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                   Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 53 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                   Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 54 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                  Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 55 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr />\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div>\r\n        <h3>Por finalizar</h3>\r\n");
#nullable restore
#line 64 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         foreach (Partido item in ViewBag.PartidosEliminatoria)
        {
            if (!item.Finalizado)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mt-4\">\r\n                    <h3>");
#nullable restore
#line 69 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                   Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 69 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                   Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 70 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                  Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <button class=\"btn-info\"><a");
            BeginWriteAttribute("href", " href=\"", 2273, "\"", 2324, 2);
            WriteAttributeValue("", 2280, "/Partido/FinalizarPartido?id=", 2280, 29, true);
#nullable restore
#line 71 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
WriteAttributeValue("", 2309, item.IDPartido, 2309, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Finalizar</a></button>\r\n                    <hr />\r\n                </div>\r\n");
#nullable restore
#line 74 "C:\Users\santi\Desktop\developORT\ObligatorioP2\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
