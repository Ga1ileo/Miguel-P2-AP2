#pragma checksum "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4acda940a08e17c0848fd42e807ac9bd3066281"
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
using Miguel_P2_AP2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
using Miguel_P2_AP2.BLL;

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
#line 10 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                 cobros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.AddMarkupContent(7, "<div class=\"card\">\n        <div class=\"card-header\">\n            <h3>Registro de Cobros</h3>\n        </div>\n    </div>\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "form");
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.AddMarkupContent(16, "<label>Id:</label>\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "input-group");
                __builder2.AddMarkupContent(19, "\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputNumber_0(__builder2, 20, 21, "form-control col-4", 22, 
#nullable restore
#line 24 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                         cobros.CobroId

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobros.CobroId = __value, cobros.CobroId)), 24, () => cobros.CobroId);
                __builder2.AddMarkupContent(25, "\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 25 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                              () => cobros.CobroId 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\n                    ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "type", "button");
                __builder2.AddAttribute(31, "class", "btn btn-primary input-group-append");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                               Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n\n\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-row");
                __builder2.AddMarkupContent(39, "\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col-6");
                __builder2.AddMarkupContent(42, "\n                    ");
                __builder2.AddMarkupContent(43, "<label>Cliente</label>\n                    ");
                __builder2.OpenElement(44, "select");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                        cobros.ClienteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cobros.ClienteId = __value, cobros.ClienteId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(48, "\n");
#nullable restore
#line 36 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                         foreach (var items in ClientesBLL.GetList())
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(49, "                            ");
                __builder2.OpenElement(50, "option");
                __builder2.AddAttribute(51, "value", 
#nullable restore
#line 38 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                            items.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(52, 
#nullable restore
#line 38 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                              items.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n");
#nullable restore
#line 39 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateValidationMessage_2(__builder2, 56, 57, 
#nullable restore
#line 41 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                              () => cobros.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n\n                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group col-10");
                __builder2.AddMarkupContent(62, "\n                    ");
                __builder2.AddMarkupContent(63, "<label>Fecha</label>\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputDate_3(__builder2, 64, 65, "form-group", 66, 
#nullable restore
#line 47 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                               cobros.Fecha

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobros.Fecha = __value, cobros.Fecha)), 68, () => cobros.Fecha);
                __builder2.AddMarkupContent(69, "\n                    ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateValidationMessage_4(__builder2, 70, 71, 
#nullable restore
#line 48 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                            (() => cobros.Fecha)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(72, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "card-header");
                __builder2.AddMarkupContent(77, "\n                ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-row");
                __builder2.AddMarkupContent(80, "\n                    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group col-5");
                __builder2.AddMarkupContent(83, "\n                        ");
                __builder2.AddMarkupContent(84, "<label>Ventas</label>\n                        ");
                __builder2.OpenElement(85, "select");
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                               ObtenerDatos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                            VentaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => VentaId = __value, VentaId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(90, "\n");
#nullable restore
#line 57 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                             foreach (var items in VentasBLL.GetList())
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(91, "                                ");
                __builder2.OpenElement(92, "option");
                __builder2.AddAttribute(93, "value", 
#nullable restore
#line 59 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                items.VentaId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(94, 
#nullable restore
#line 59 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                items.VentaId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n");
#nullable restore
#line 60 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(96, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n                        ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group-append");
                __builder2.AddMarkupContent(100, "\n                            ");
                __builder2.OpenElement(101, "button");
                __builder2.AddAttribute(102, "type", "button");
                __builder2.AddAttribute(103, "class", "btn btn-primary input-group-append");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                                       agregarAlDetalle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(105, "AgregarAlGrid");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\n\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\n\n            ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "table-responsive text-nowrap");
                __builder2.AddMarkupContent(113, "\n                ");
                __builder2.AddMarkupContent(114, "<label>Facturas Pendientes</label>\n                ");
                __builder2.OpenElement(115, "table");
                __builder2.AddAttribute(116, "class", "table table-striped");
                __builder2.AddMarkupContent(117, "\n                    ");
                __builder2.AddMarkupContent(118, @"<thead class=""thead-light"">
                        <tr>
                            <th>Id</th>
                            <th>Fecha</th>
                            <th>Monto</th>
                            <th>Balance</th>
                            <th>Cobrado</th>
                            <th>Pagar</th>
                            <th>     </th>
                        </tr>
                    </thead>
                    ");
                __builder2.OpenElement(119, "tbody");
                __builder2.AddAttribute(120, "class", "bg-white");
                __builder2.AddMarkupContent(121, "\n");
#nullable restore
#line 85 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                         foreach (var item in cobros.CobrosDetalle)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "                            ");
                __builder2.OpenElement(123, "tr");
                __builder2.AddMarkupContent(124, "\n                                ");
                __builder2.OpenElement(125, "td");
                __builder2.AddContent(126, 
#nullable restore
#line 88 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     VentasBLL.Buscar(item.VentaId).VentaId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\n                                ");
                __builder2.OpenElement(128, "td");
                __builder2.AddContent(129, 
#nullable restore
#line 89 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     VentasBLL.Buscar(item.VentaId).Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n                                ");
                __builder2.OpenElement(131, "td");
                __builder2.AddContent(132, 
#nullable restore
#line 90 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     VentasBLL.Buscar(item.VentaId).Monto

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\n                                ");
                __builder2.OpenElement(134, "td");
                __builder2.AddContent(135, 
#nullable restore
#line 91 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                     VentasBLL.Buscar(item.VentaId).Balance

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\n                                ");
                __builder2.OpenElement(137, "td");
                __builder2.AddContent(138, 
#nullable restore
#line 92 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                      item.Pagar == true ? VentasBLL.Buscar(item.VentaId).Balance : item.Cobrado

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\n                                ");
                __builder2.OpenElement(140, "td");
                __builder2.OpenElement(141, "input");
                __builder2.AddAttribute(142, "type", "checkbox");
                __builder2.AddAttribute(143, "class", "form-check-input");
                __builder2.AddAttribute(144, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                                                 CalcularCobrado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(145, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                           item.Pagar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(146, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Pagar = __value, item.Pagar));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\n                                ");
                __builder2.OpenElement(148, "td");
                __builder2.OpenElement(149, "button");
                __builder2.AddAttribute(150, "type", "button");
                __builder2.AddAttribute(151, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                                   (() => EliminarDetalle(item))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(153, "Remover");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\n");
#nullable restore
#line 96 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(156, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\n\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\n\n            ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "card-footer");
                __builder2.AddMarkupContent(162, "\n                ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "form-row");
                __builder2.AddMarkupContent(165, "\n                    ");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "form-group col-4");
                __builder2.AddMarkupContent(168, "\n                        ");
                __builder2.AddMarkupContent(169, "<label>Totales</label>\n                        ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputNumber_5(__builder2, 170, 171, "form-control", 172, 
#nullable restore
#line 107 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                       cobros.Totales

#line default
#line hidden
#nullable disable
                , 173, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobros.Totales = __value, cobros.Totales)), 174, () => cobros.Totales);
                __builder2.AddMarkupContent(175, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\n                    ");
                __builder2.AddMarkupContent(177, "<div class=\"col-3\">\n\n                    </div>\n                    ");
                __builder2.OpenElement(178, "div");
                __builder2.AddAttribute(179, "class", "form-group col-10-3");
                __builder2.AddMarkupContent(180, "\n                        ");
                __builder2.AddMarkupContent(181, "<label>Total</label>\n                        ");
                __Blazor.Miguel_P2_AP2.Pages.RegistroCobros.TypeInference.CreateInputNumber_6(__builder2, 182, 183, "form-control", 184, 
#nullable restore
#line 114 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                       TotalCobrado

#line default
#line hidden
#nullable disable
                , 185, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TotalCobrado = __value, TotalCobrado)), 186, () => TotalCobrado);
                __builder2.AddMarkupContent(187, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(188, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(189, "\n\n                ");
                __builder2.OpenElement(190, "div");
                __builder2.AddAttribute(191, "class", "form-row");
                __builder2.AddMarkupContent(192, "\n                    ");
                __builder2.OpenElement(193, "div");
                __builder2.AddAttribute(194, "class", "form-group col-12");
                __builder2.AddMarkupContent(195, "\n                        ");
                __builder2.AddMarkupContent(196, "<label>Observaciones</label>\n                        ");
                __builder2.OpenElement(197, "textarea");
                __builder2.AddAttribute(198, "class", "form-control");
                __builder2.AddAttribute(199, "rows", "2");
                __builder2.AddAttribute(200, "cols", "20");
                __builder2.AddAttribute(201, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 121 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                              cobros.Observaciones

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(202, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cobros.Observaciones = __value, cobros.Observaciones));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(203, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(204);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(205, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(206, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(207, "\n\n                ");
                __builder2.OpenElement(208, "div");
                __builder2.AddAttribute(209, "class", "form-group text-center");
                __builder2.AddAttribute(210, "display:", true);
                __builder2.AddAttribute(211, "inline-block", true);
                __builder2.AddMarkupContent(212, "\n                    ");
                __builder2.OpenElement(213, "button");
                __builder2.AddAttribute(214, "type", "button");
                __builder2.AddAttribute(215, "class", "btn btn-lg btn-secondary");
                __builder2.AddAttribute(216, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                     Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(217, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(218, "\n                    ");
                __builder2.AddMarkupContent(219, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\n                    ");
                __builder2.OpenElement(220, "button");
                __builder2.AddAttribute(221, "type", "button");
                __builder2.AddAttribute(222, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(223, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 129 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
                                                                                  Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(224, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(225, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(226, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(227, "\n\n           \n           \n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(228, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(229, "\n\n    \n\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "/Users/miguelgondres/Projects/Miguel-P2-AP2/Pages/RegistroCobros.razor"
       

    private Cobros cobros = new Cobros();

    public int VentaId { get; set; }

    public double Monto { get; set; }
    public double Balance { get; set; }
    public double Cobrado { get; set; }
    public double TotalCobrado { get; set; }
    public int CobrosId { get; set; }
    public bool Pagar { get; set; }

    public List<Clientes> ListaClientes = new List<Clientes>();

    protected override void OnInitialized()
    {
        Nuevo();
        Buscar();
    }

    public void Nuevo()
    {
        cobros = new Cobros();
    }

    public void Guardar()
    {
        bool guardado = CobrosBLL.Guardar(cobros);
        if (guardado)
        {
            Nuevo();
            toast.ShowSuccess("Guardado");
        }
        else
        {
            toast.ShowError("No Guardado");
        }
    }

    public void Buscar()
    {
        if(cobros.CobroId > 0)
        {
            var encontrado = CobrosBLL.Buscar(cobros.CobroId);

            if (encontrado != null)
            {
                this.cobros = encontrado;
            }
            else
            {
                toast.ShowError("No encontrado");
            }

        }
    }

    public void Eliminar()
    {
        bool eliminado = CobrosBLL.Eliminar(cobros.CobroId);

        if (eliminado)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado Perfectamente");
        }
        else
        {
            toast.ShowError("Hubo un error");
        }
    }

    public void agregarAlDetalle()
    {
        cobros.CobrosDetalle.Add(new CobrosDetalle
        {
            CobroDetalleId = 0,
            CobroId = cobros.CobroId,
            VentaId = VentaId,
            Fecha = DateTime.Now,
            Monto = Monto,
            Balance = Balance,
            Cobrado = Cobrado,
            Pagar = Pagar,
        });



    }

    public void ObtenerDatos()
    {
        var ventas = VentasBLL.Buscar(VentaId);
    }

    private void EliminarDetalle(CobrosDetalle detalle)
    {
        cobros.CobrosDetalle.Remove(detalle);
        CalcularMonto();
    }

    public void CalcularMonto()
    {
        cobros.Totales = 0;
        foreach(var items in cobros.CobrosDetalle)
        {
            cobros.Totales += VentasBLL.Buscar(items.VentaId).Monto;
        }
    }

    public void CalcularCobrado()
    {
        foreach(var items in cobros.CobrosDetalle)
        {
            if (items.Pagar)
            {
                TotalCobrado += items.Balance;
            }
            else
            {
                TotalCobrado += 0;
            }
        }
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
