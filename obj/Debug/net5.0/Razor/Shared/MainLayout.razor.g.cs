#pragma checksum "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "766919fe97fd7c0565d5ac4d0be0d94d0fe1db95"
// <auto-generated/>
#pragma warning disable 1591
namespace MVVM_Sample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using MVVM_Sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/_Imports.razor"
using MVVM_Sample.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ytgm8akrm5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-ytgm8akrm5");
            __builder.OpenComponent<MVVM_Sample.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-ytgm8akrm5");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-ytgm8akrm5><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-ytgm8akrm5>About</a></div>\n\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-ytgm8akrm5");
#nullable restore
#line 14 "/Users/magizhan/DotNet/MVVM-Sample/MVVM-Sample/Shared/MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591