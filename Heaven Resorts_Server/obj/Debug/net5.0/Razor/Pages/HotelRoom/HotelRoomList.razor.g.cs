#pragma checksum "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb8679f53ce1c2110022998ab4f6bf7dea65e30"
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
#line 12 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\_Imports.razor"
using Blazored.TextEditor;

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
#nullable restore
#line 4 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
using Heaven_Resorts_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
using Heaven_Resorts_Server.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
using Heaven_Resorts_Server.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

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
#line 34 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
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
#line 39 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(21, room.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 40 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(24, room.Occupancy);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 41 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(27, room.RegularRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 42 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(30, room.SqFt);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 43 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(33, room.Details);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "href", 
#nullable restore
#line 45 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
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
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-danger");
            __builder.AddAttribute(44, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                                         () =>HandleDelete(room.Id) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                    }

                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<tr><td colspan=\"6\">No records found</td></tr>");
#nullable restore
#line 57 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.OpenComponent<global::Heaven_Resorts_Server.Shared.DeleteConfirmation>(48);
            __builder.AddAttribute(49, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 63 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                                         ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(50, "IsParentComponentProcessing", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 63 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                                                           IsProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Pages\HotelRoom\HotelRoomList.razor"
       

    private IEnumerable<HotelRoomDTO> model { get; set; } = new List<HotelRoomDTO>();
    private int? DeleteRoomId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;
    string x = "";
    protected override async Task OnInitializedAsync()
    {
        model = await HotelRoomRepository.GetAllHotelRooms();
    }

    #region Comment

    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    //}

    #endregion
    private async Task HandleDelete(int roomId)
    {
        DeleteRoomId = roomId;

        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }
    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteRoomId != null)
        {
            HotelRoomDTO hotelRoom = await HotelRoomRepository.GetHotelRoom(DeleteRoomId.Value);
            foreach (var image in hotelRoom.HotelRoomImages)
            {
                // x = $"{NavigationManager.BaseUri}RoomImages/";
                var imageName = image.RoomImageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");

                FileUpload.DeleteFile(imageName);
            }

            await HotelRoomRepository.DeleteHotelRoom(DeleteRoomId.Value);
            await JsRuntime.ToastrSuccess("Hotel Room Deleted successfully");
            model = await HotelRoomRepository.GetAllHotelRooms();
        }
        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
