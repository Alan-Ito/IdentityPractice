#pragma checksum "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0749224026d36a43cf022f8e593ee9b69b1bcd8a"
// <auto-generated/>
#pragma warning disable 1591
namespace ja3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using ja3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\_Imports.razor"
using ja3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "Identity/Manage/Index");
                __builder2.AddMarkupContent(4, "\r\n            Hello, ");
                __builder2.AddContent(5, 
#nullable restore
#line 8 "C:\Users\alant\OneDrive\Documents\SSTN\Blazor Practice\ja3\Shared\LoginDisplay.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "!\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<form method=\"post\" action=\"/Identity/Logout\"><button type=\"submit\" class=\"nav-link btn btn-link\">Log out</button></form>");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<a href=\"Identity/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(11, "<a href=\"Identity/Login\">Login</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
