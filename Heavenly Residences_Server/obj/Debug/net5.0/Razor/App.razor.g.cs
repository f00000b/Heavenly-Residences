#pragma checksum "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f650d62b5cce0fc8a5743184bcbab48913f8d5a"
// <auto-generated/>
#pragma warning disable 1591
namespace Heavenly_Residences_Server
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Heavenly_Residences_Server.Pages.MyComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", 
#nullable restore
#line 3 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(5, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 5 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<global::Radzen.Blazor.RadzenStack>(10);
                        __builder4.AddAttribute(11, "Gap", "0");
                        __builder4.AddAttribute(12, "class", "rz-py-8 rz-px-12");
                        __builder4.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::Radzen.Blazor.RadzenAlert>(14);
                            __builder5.AddAttribute(15, "AlertStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.AlertStyle>(
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                 AlertStyle.Danger

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(16, "ShowIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                              false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(17, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Variant>(
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                                              Variant.Flat

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(18, "Shade", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Shade>(
#nullable restore
#line 11 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                                                                   Shade.Lighter

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(19, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(20, "<p>Sorry ! You Do not have Access to this Page...</p>");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(21, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(22);
                    __builder3.AddAttribute(23, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 22 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::Radzen.Blazor.RadzenStack>(25);
                        __builder4.AddAttribute(26, "Gap", "0");
                        __builder4.AddAttribute(27, "class", "rz-py-8 rz-px-12");
                        __builder4.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::Radzen.Blazor.RadzenAlert>(29);
                            __builder5.AddAttribute(30, "Title", "WOW!");
                            __builder5.AddAttribute(31, "AlertStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.AlertStyle>(
#nullable restore
#line 25 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                          AlertStyle.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Variant>(
#nullable restore
#line 25 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                                    Variant.Flat

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "Shade", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Shade>(
#nullable restore
#line 25 "D:\Projects\Heavenly Residences\Heavenly Residences_Server\App.razor"
                                                                                                         Shade.Lighter

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(34, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(35, "<p>Sorry, there\'s nothing at this address.</p>");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
