#pragma checksum "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea6986f8b39b6d05c83c9bea96887f56bffb4069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Usuario.Pages_Usuario_Details), @"mvc.1.0.razor-page", @"/Pages/Usuario/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Usuario
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
#line 1 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6986f8b39b6d05c83c9bea96887f56bffb4069", @"/Pages/Usuario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Usuario_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
  
    var Usuario = Model.Usuario;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>ID: </b> ");
#nullable restore
#line 8 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                      Write(Usuario.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Nombre: </b> ");
#nullable restore
#line 9 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                          Write(Usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Apellidos: </b> ");
#nullable restore
#line 10 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                             Write(Usuario.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Dirección: </b> ");
#nullable restore
#line 11 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                            Write(Usuario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Ciudad: </b> ");
#nullable restore
#line 12 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                         Write(Usuario.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Teléfono: </b> ");
#nullable restore
#line 13 "C:\Users\crisc\Downloads\client\PRUEBAS\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                           Write(Usuario.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\t\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
