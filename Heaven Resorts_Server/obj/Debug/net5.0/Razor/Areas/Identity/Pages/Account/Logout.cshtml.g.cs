#pragma checksum "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "917417398b4ff39fbc5386022810ee454b82f26c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
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
#nullable restore
#line 2 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using Heaven_Resorts_Server.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using Heaven_Resorts_Server.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Heaven_Resorts_Server.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Areas\Identity\Pages\Account\Logout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917417398b4ff39fbc5386022810ee454b82f26c", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f59994ec314742f16479e71930f482906c8e7aa", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b6610eb68a277cf3cc8fb446635d8456e698ae", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(" ");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Heaven Resorts\Heaven Resorts\Heaven Resorts_Server\Areas\Identity\Pages\Account\Logout.cshtml"
           

    public async Task<IActionResult> OnGet()
    {
        if (SignInManager.IsSignedIn(User))
        {
            await SignInManager.SignOutAsync();
        }

        return Redirect("~/");
    }


#line default
#line hidden
#nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Logout> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Logout> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Logout>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Logout Model => ViewData.Model;
    }
}
#pragma warning restore 1591
