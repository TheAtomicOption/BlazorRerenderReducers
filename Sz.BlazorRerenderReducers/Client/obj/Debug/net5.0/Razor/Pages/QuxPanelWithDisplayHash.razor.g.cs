#pragma checksum "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89599b11ed03df216e71dc54c94a56b57718d760"
// <auto-generated/>
#pragma warning disable 1591
namespace Sz.BlazorRerenderReducers.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Sz.BlazorRerenderReducers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\_Imports.razor"
using Sz.BlazorRerenderReducers.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
using BlazorRerenderReducers;

#line default
#line hidden
#nullable disable
    public partial class QuxPanelWithDisplayHash : DisplayHashRerenderComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display:flex;");
#nullable restore
#line 5 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
     foreach (int i in Enumerable.Range(0, 1000))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "display: none;");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
                                     i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\nnested QuxPanelWithDisplayHash component with Baz=");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
                                                   InputFoo.Qux

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "display:flex;");
#nullable restore
#line 14 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
 foreach (int i in Enumerable.Range(0, 1000))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "display: block;");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
                                  i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\s\Sz.BlazorRerenderReducers\Sz.BlazorRerenderReducers\Client\Pages\QuxPanelWithDisplayHash.razor"
       
    [Parameter]
    public Foo InputFoo { get; set; } = null!;

    protected override string GetDisplayHash() => InputFoo.Qux.ToString();

    private ScopeTimer RenderTimer { get; } = new("QuxPanelWithDisplayHash");

    protected override void OnInitialized() => OnParametersSet();
    protected override void OnParametersSet()
    {
        RenderTimer.Init();
    }
    protected override void OnAfterRender(bool firstRender)
    {
        RenderTimer.Dispose();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
