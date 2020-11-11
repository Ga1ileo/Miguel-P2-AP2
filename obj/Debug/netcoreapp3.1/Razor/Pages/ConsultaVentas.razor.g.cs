#pragma checksum "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269567d36d2ab0f10f6e0534f78f7db6b9d7a398"
// <auto-generated/>
#pragma warning disable 1591
namespace Miguel_P2_AP2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Miguel_P2_AP2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Miguel_P2_AP2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/miguelgondres/Projects/Miguel-P2-AP2/_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
using Miguel_P2_AP2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
using Miguel_P2_AP2.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ventas")]
    public partial class ConsultaVentas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\"><h3>Consulta de Pedidos</h3></div>\n\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-6");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "input-group mb-3");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                                                                filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filtro = __value, filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "0");
            __builder.AddContent(21, "Todos");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "input-group-append");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                                                                                        Consultar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n    ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table");
            __builder.AddMarkupContent(33, "<thead class=\"thead-light\"><tr><th>VentaId</th>\n                <th>Fecha</th>\n                <th>ClienteId</th>\n                <th>Monto</th>\n                <th>Balance</th></tr></thead>\n        ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 45 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
             foreach (var item in lista)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 48 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                         item.VentaId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 49 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                         item.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 50 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                         item.ClienteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 51 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                         item.Monto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 52 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
                         item.Balance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/ConsultaVentas.razor"
       

    public int filtro { get; set; }
    public List<Ventas> lista = new List<Ventas>();


    private void Consultar()
    {
        try
        {
            switch (filtro)
            {
                case 0:
                    this.lista = VentasBLL.GetList(p => true);
                    break;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
