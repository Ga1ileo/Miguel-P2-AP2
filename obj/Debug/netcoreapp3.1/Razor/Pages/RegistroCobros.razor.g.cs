#pragma checksum "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc5c2e198a2047d84f6237932262653dd19b04b5"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                 cobros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n\n    ");
                __builder2.AddMarkupContent(6, "<div class=\"card\"><div class=\"card-header\"><h3>Registro de Cobros</h3>\n            <h6>Disculpe profe, hay que darle click a la tabla para actualizarla luego de seleccionar un cliente (para que le salgan las facturas)</h6></div></div>\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card-body");
                __builder2.OpenElement(9, "form");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label>Id:</label>\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "input-group");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputNumber_0(__builder2, 15, 16, "form-control col-4", 17, 
#nullable restore
#line 24 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                         cobros.CobroId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobros.CobroId = __value, cobros.CobroId)), 19, () => cobros.CobroId);
                __builder2.AddMarkupContent(20, "\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateValidationMessage_1(__builder2, 21, 22, 
#nullable restore
#line 25 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                              () => cobros.CobroId 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\n                    ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "type", "button");
                __builder2.AddAttribute(26, "class", "btn btn-primary input-group-append");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                               Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Buscar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n\n\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label>Cliente ID</label>\n                    ");
                __builder2.OpenElement(35, "select");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 35 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                   ObtenerVentasPendientes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                   cobros.ClienteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cobros.ClienteId = __value, cobros.ClienteId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(40, "option");
                __builder2.AddAttribute(41, "value", "0");
                __builder2.AddAttribute(42, "disabled", true);
                __builder2.AddAttribute(43, "selected", true);
                __builder2.AddContent(44, "Seleccione un cliente");
                __builder2.CloseElement();
#nullable restore
#line 38 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                         foreach (var item in ClienteLista)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "value", 
#nullable restore
#line 40 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                            item.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(47, 
#nullable restore
#line 40 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                             item.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 41 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n\n\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group col-10");
                __builder2.AddMarkupContent(51, "<label>Fecha</label>\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputDate_2(__builder2, 52, 53, "form-group", 54, 
#nullable restore
#line 49 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                               cobros.Fecha

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobros.Fecha = __value, cobros.Fecha)), 56, () => cobros.Fecha);
                __builder2.AddMarkupContent(57, "\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateValidationMessage_3(__builder2, 58, 59, 
#nullable restore
#line 50 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                            (() => cobros.Fecha)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n\n            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "table");
                __builder2.AddMarkupContent(63, "<label>Facturas Pendientes</label>\n                ");
                __builder2.OpenElement(64, "table");
                __builder2.AddAttribute(65, "class", "table table-striped");
                __builder2.AddMarkupContent(66, @"<thead><tr><th>ID</th>
                            <th>Fecha</th>
                            <th>Monto</th>
                            <th>Balance</th>
                            <th>Cobrado</th>
                            <th>Pagar</th></tr></thead>
                    ");
                __builder2.OpenElement(67, "tbody");
                __builder2.AddAttribute(68, "style", "background-color: white;");
#nullable restore
#line 69 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                         foreach (var item in cobros.CobrosDetalle)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(69, "tr");
                __builder2.OpenElement(70, "td");
                __builder2.AddContent(71, 
#nullable restore
#line 72 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     item.VentaId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n                                ");
                __builder2.OpenElement(73, "td");
                __builder2.AddContent(74, 
#nullable restore
#line 73 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     item.Venta.Fecha.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n                                ");
                __builder2.OpenElement(76, "td");
                __builder2.AddContent(77, 
#nullable restore
#line 74 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     item.Venta.Monto.ToString("N2")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n                                ");
                __builder2.OpenElement(79, "td");
                __builder2.AddContent(80, 
#nullable restore
#line 75 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     item.Venta.Balance.ToString("N2")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n                                ");
                __builder2.OpenElement(82, "td");
                __builder2.AddContent(83, 
#nullable restore
#line 76 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     item.Cobrado.ToString("N2")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n                                ");
                __builder2.OpenElement(85, "td");
                __builder2.OpenElement(86, "input");
                __builder2.AddAttribute(87, "type", "checkbox");
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 77 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                         () => Cobrar(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 79 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", " form-group form-inline");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group col-6");
                __builder2.AddMarkupContent(94, "<label>Totales</label>\n                        ");
                __builder2.OpenElement(95, "span");
                __builder2.AddAttribute(96, "class", "form-control");
                __builder2.AddContent(97, 
#nullable restore
#line 87 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                    cobros.CobrosDetalle.Count()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\n\n                    ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group col-6");
                __builder2.AddMarkupContent(101, "<label>Total cobrado</label>\n                        ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputNumber_4(__builder2, 102, 103, "form-control", 104, "true", 105, 
#nullable restore
#line 92 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                  cobros.TotalCobrado

#line default
#line hidden
#nullable disable
                , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobros.TotalCobrado = __value, cobros.TotalCobrado)), 107, () => cobros.TotalCobrado);
                __builder2.AddMarkupContent(108, "\n                        ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateValidationMessage_5(__builder2, 109, 110, 
#nullable restore
#line 93 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                  () => cobros.TotalCobrado

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n\n                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group ");
                __builder2.AddMarkupContent(114, "<label>Observaciones</label>\n                    ");
                __builder2.OpenElement(115, "textarea");
                __builder2.AddAttribute(116, "class", "form-control");
                __builder2.AddAttribute(117, "row", "5");
                __builder2.AddAttribute(118, "placeholder", "Observaciones");
                __builder2.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     cobros.Observaciones

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cobros.Observaciones = __value, cobros.Observaciones));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n        ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "card-footer");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group text-center");
                __builder2.AddAttribute(126, "display:", true);
                __builder2.AddAttribute(127, "inline-block", true);
                __builder2.OpenElement(128, "button");
                __builder2.AddAttribute(129, "type", "button");
                __builder2.AddAttribute(130, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                               Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(132, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\n                ");
                __builder2.OpenElement(134, "button");
                __builder2.AddAttribute(135, "type", "submit");
                __builder2.AddAttribute(136, "class", "btn btn-lg btn-success");
                __builder2.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                               Guardar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(138, "Guardar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\n                ");
                __builder2.OpenElement(140, "button");
                __builder2.AddAttribute(141, "type", "button");
                __builder2.AddAttribute(142, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(144, "Eliminar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
       

    Cobros cobros = new Cobros();
    Clientes cliente = new Clientes();
    Ventas ventas = new Ventas();

    List<Clientes> ClienteLista = new List<Clientes>();
    List<CobrosDetalle> VentaLista = new List<CobrosDetalle>();

    protected override void OnInitialized()
    {
        Nuevo();
    }

    private void Nuevo()
    {
        cobros = new Cobros();
        ClienteLista = ClientesBLL.GetList(c => true);
        VentaLista = new List<CobrosDetalle>();
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
namespace __Blazor.Miguel_P2_AP2.Pages.RegistroCobros
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "readOnly", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
