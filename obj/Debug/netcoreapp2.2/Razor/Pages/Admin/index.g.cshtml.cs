#pragma checksum "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81d9d5da8476fc825be6fbc16b5feb0750a95fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_index), @"mvc.1.0.razor-page", @"/Pages/Admin/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/index.cshtml", typeof(AspNetCore.Pages_Admin_index), null)]
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
#line 1 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 2 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\_ViewImports.cshtml"
using CotizacionesPersonales;

#line default
#line hidden
#line 3 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\_ViewImports.cshtml"
using CotizacionesPersonales.Data;

#line default
#line hidden
#line 4 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\_ViewImports.cshtml"
using CotizacionesPersonales.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81d9d5da8476fc825be6fbc16b5feb0750a95fa", @"/Pages/Admin/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bcec85789e11e89a04a0a6cf64c7d8a459fe38", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
  
    ViewData["Title"] = "Admin Home";

#line default
#line hidden
            BeginContext(103, 226, true);
            WriteLiteral("\r\n<h3>DashBoard</h3>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Nombre </th>\r\n            <th>telefono </th>\r\n            <th>Direccion </th>\r\n            <th>Email </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 20 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
         foreach (var cliente in Model.Clientes ){

#line default
#line hidden
            BeginContext(381, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(420, 21, false);
#line 22 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(cliente.NombreCliente);

#line default
#line hidden
            EndContext();
            BeginContext(441, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(469, 23, false);
#line 23 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(cliente.TelefonoCliente);

#line default
#line hidden
            EndContext();
            BeginContext(492, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(520, 24, false);
#line 24 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(cliente.DireccionCliente);

#line default
#line hidden
            EndContext();
            BeginContext(544, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(572, 20, false);
#line 25 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(cliente.EmailCliente);

#line default
#line hidden
            EndContext();
            BeginContext(592, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
        }

#line default
#line hidden
            BeginContext(629, 34, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(825, 210, true);
            WriteLiteral("\r\n<table>\r\n    <caption>Servicios</caption>\r\n    <thead>\r\n        <tr>\r\n            <th>Servicio</th>\r\n            <th>Descripcion </th>\r\n            <th>Precio </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
         foreach (var servicio in Model.Servicios ){

#line default
#line hidden
            BeginContext(1089, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1128, 23, false);
#line 50 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(servicio.NombreServicio);

#line default
#line hidden
            EndContext();
            BeginContext(1151, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1180, 28, false);
#line 51 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(servicio.DescripcionServicio);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1237, 81, false);
#line 52 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
               Write(servicio.PrecioServicio.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 27, true);
            WriteLiteral(" </td>\r\n            </tr>\r\n");
            EndContext();
#line 54 "d:\WorkSpace\vcode\PalmaDesign\cotizacionPersonales\Pages\Admin\index.cshtml"
        }

#line default
#line hidden
            BeginContext(1356, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CotizacionesPersonales.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CotizacionesPersonales.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CotizacionesPersonales.Pages.IndexModel>)PageContext?.ViewData;
        public CotizacionesPersonales.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
