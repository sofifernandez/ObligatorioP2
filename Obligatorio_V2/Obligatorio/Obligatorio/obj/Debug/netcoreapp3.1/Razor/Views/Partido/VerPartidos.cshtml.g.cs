#pragma checksum "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dec0d98b00b691c1c9ea13f1146577f8ddc21544"
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
#line 1 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec0d98b00b691c1c9ea13f1146577f8ddc21544", @"/Views/Partido/VerPartidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c816bb28de69d7646d9da673eaff207aa081", @"/Views/_ViewImports.cshtml")]
    public class Views_Partido_VerPartidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Partidos</h1>\r\n<div>\r\n    <h2>Partidos Fase de Grupos</h2>\r\n    <div>\r\n        <h3>Finalizados</h3>\r\n");
#nullable restore
#line 14 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         foreach (Partido item in ViewBag.PartidosGrupo)
        {
            if (item.Finalizado)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card text-center my-3 col-6\">\r\n                    <div class=\"card-header\">\r\n                        <h5 class=\"card-title bg-dark text-white\">");
#nullable restore
#line 20 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                             Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 20 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                                                             Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        \r\n                        <p class=\"card-text\">");
#nullable restore
#line 24 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                        Write(item.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-footer text-muted\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                   Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         if (Context.Session.GetString("rol") == "OPERADOR")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>Por finalizar</h3>\r\n");
#nullable restore
#line 39 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
             foreach (Partido item in ViewBag.PartidosGrupo)
            {
                if (!item.Finalizado)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card text-center my-3 col-6\">\r\n                        <div class=\"card-header\">\r\n                            <h5 class=\"card-title bg-success text-white\">");
#nullable restore
#line 45 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                                    Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 45 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                                                                    Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1701, "\"", 1752, 2);
            WriteAttributeValue("", 1708, "/Partido/FinalizarPartido?id=", 1708, 29, true);
#nullable restore
#line 49 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
WriteAttributeValue("", 1737, item.IDPartido, 1737, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Finalizar</a>\r\n                        </div>\r\n                        <div class=\"card-footer text-muted\">\r\n                            ");
#nullable restore
#line 52 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                       Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 55 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"

                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <h2>Partidos Fase Eliminatorias</h2>\r\n    <div>\r\n        <h3>Finalizados</h3>\r\n");
#nullable restore
#line 67 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         foreach (Partido item in ViewBag.PartidosEliminatoria)
        {
            if (item.Finalizado)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card text-center my-3 col-6\">\r\n                    <div class=\"card-header\">\r\n                        <h5 class=\"card-title bg-dark text-white\">");
#nullable restore
#line 73 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                             Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 73 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                                                             Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n\r\n                        <p class=\"card-text\">");
#nullable restore
#line 77 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                        Write(item.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-footer text-muted\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                   Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 83 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div>\r\n");
#nullable restore
#line 88 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
         if (Context.Session.GetString("rol") == "OPERADOR")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>Por finalizar</h3>\r\n");
#nullable restore
#line 91 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
             foreach (Partido item in ViewBag.PartidosEliminatoria)
            {
                if (!item.Finalizado)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card text-center my-3 col-6\">\r\n                        <div class=\"card-header bg-success text-white\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 97 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                              Write(item.SeleccionA.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 97 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                                                                              Write(item.SeleccionB.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3552, "\"", 3603, 2);
            WriteAttributeValue("", 3559, "/Partido/FinalizarPartido?id=", 3559, 29, true);
#nullable restore
#line 101 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
WriteAttributeValue("", 3588, item.IDPartido, 3588, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Finalizar</a>\r\n                        </div>\r\n                        <div class=\"card-footer text-muted\">\r\n                            ");
#nullable restore
#line 104 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
                       Write(item.FechaPartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 107 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"

                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\sofia\OneDrive\ORT\Semestre2\P2\Obligatorio\Obligatorio_V2\Obligatorio\Obligatorio\Views\Partido\VerPartidos.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
