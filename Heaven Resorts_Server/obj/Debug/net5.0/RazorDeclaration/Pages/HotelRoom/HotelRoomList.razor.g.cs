// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
