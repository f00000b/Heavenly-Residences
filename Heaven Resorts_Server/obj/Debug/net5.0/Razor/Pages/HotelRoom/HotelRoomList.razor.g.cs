#pragma checksum "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d955f1c8612afac9a657f06f920b129545d90bdf"
// <auto-generated/>
#pragma warning disable 1591
namespace Heaven_Resorts_Server.Pages.HotelRoom
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Heaven_Resorts_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Heaven_Resorts_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Heaven_Resorts_Server.Pages.MyComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room")]
    public partial class HotelRoomList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Hotel Room\'s</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "hotel-room/create");
            __builder.AddAttribute(7, "class", "btn btn-info form-control");
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Add New Room");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><th>Name</th>\r\n                    <th>Occupancy</th>\r\n                    <th>Rate</th>\r\n                    <th>Sqft</th>\r\n                    <th>Details</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 29 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
             if (model.Any())
            {
                foreach (var room in model)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
#nullable restore
#line 34 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(21, room.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 35 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(24, room.Occupancy);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 36 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(27, room.RegularRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 37 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(30, room.SqFt);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 38 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(33, room.Details);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "href", 
#nullable restore
#line 40 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                                             $"/hotel-room/edit/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.AddMarkupContent(42, "<button>Delete</button>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                }
               
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<tr><td colspan=\"6\">No records found</td></tr>");
#nullable restore
#line 52 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
       

    private IEnumerable<HotelRoomDTO> model { get; set; } = new List<HotelRoomDTO>();

    protected override async Task OnInitializedAsync()
    {
        model = await HotelRoomRepository.GetAllHotelRooms();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
