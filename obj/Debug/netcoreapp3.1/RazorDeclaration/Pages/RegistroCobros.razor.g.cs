#pragma checksum "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65185a92ec92329b3b41ab2b741c8dbc0fa2b33e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
using Miguel_P2_AP2.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
using Miguel_P2_AP2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
using Miguel_P2_AP2.DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cobro")]
    public partial class RegistroCobros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
       

    Cobros cobros = new Cobros();
    Clientes cliente = new Clientes();
    Ventas ventas = new Ventas();

    List<Clientes> ClienteList = new List<Clientes>();
    List<CobrosDetalle> VentaList = new List<CobrosDetalle>();

    protected override void OnInitialized()
    {
        Nuevo();
    }

    private async void Nuevo()
    {
        cobros = new Cobros();
        await VentasBLL.GetVentasPendiente(cliente.ClienteId);
        ClienteList = ClientesBLL.GetList(c => true);
        VentaList = new List<CobrosDetalle>();
        cobros.Fecha = DateTime.Now;
    }

    private void Guardar()
    {
        bool guardado;

        cobros.CobrosDetalle.RemoveAll(d => d.Cobrado == 0);

        guardado = CobrosBLL.Guardar(cobros);

        if (guardado)
        {
            toast.ShowSuccess("Guardado correctamente");
            Nuevo();
        }
        else
            toast.ShowError("No se pudo guardar correctamente");

    }

    private async Task Buscar()
    {
        var Cobro = CobrosBLL.Buscar(cobros.CobroId);

        Cobro.CobrosDetalle = await VentasBLL.GetVentasCobradas(Cobro.ClienteId);

        if (Cobro != null)
            this.cobros = Cobro;
        else
            toast.ShowError("El cobro no existe");
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = CobrosBLL.Eliminar(cobros.CobroId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
            toast.ShowError("No fue posible eliminar");
    }

    private void Cobrar(CobrosDetalle cobroDetalle)
    {
        if (cobroDetalle.Cobrado == 0)
        {
            cobroDetalle.Cobrado = cobroDetalle.Venta.Balance;
            cobros.TotalCobrado += cobroDetalle.Cobrado;
        }
        else
        {
            cobroDetalle.Cobrado = 0;
            cobros.TotalCobrado -= cobroDetalle.Venta.Balance;
        }
    }

    private async Task ObtenerVentasPendientes()
    {
        if (cobros.CobroId == 0)
            cobros.CobrosDetalle = await VentasBLL.GetVentasPendiente(cobros.ClienteId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
