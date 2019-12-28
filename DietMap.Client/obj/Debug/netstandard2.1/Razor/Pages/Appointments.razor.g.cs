#pragma checksum "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679769026875a986e14d967bf5907f6b123f35a6"
// <auto-generated/>
#pragma warning disable 1591
namespace DietMap.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using DietMap.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using DietMap.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/acid/Documents/projects/DietMap/DietMap.Client/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
using DietMap.Client.Classes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/appointmentsList")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/appointmentsList/{clientId}/{clientName}")]
    public partial class Appointments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "headerApp");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddContent(4, "List of appointments ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                              ClientName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(7);
            __builder.AddAttribute(8, "class", "newAppointmentBtn");
            __builder.AddAttribute(9, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                                  _=>NewAppointment()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\n        New Appointment\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n");
#nullable restore
#line 16 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
 if (SelectedAppointment == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.AddMarkupContent(16, @"<div>
        <svg class=""spinner"" width=""65px"" height=""65px"" viewBox=""0 0 66 66"" xmlns=""http://www.w3.org/2000/svg"">
            <circle class=""circle"" fill=""none"" stroke-width=""6"" stroke-linecap=""round"" cx=""33"" cy=""33"" r=""30""></circle>
        </svg>
    </div>
");
#nullable restore
#line 25 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "rowAppointments");
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "columnAppointments");
            __builder.AddMarkupContent(23, "\n            ");
            __builder.OpenComponent<MatBlazor.MatButton>(24);
            __builder.AddAttribute(25, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                CantGoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                                       _=>PreviousAppointment()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "\n                Prev");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "columnAppointments");
            __builder.AddMarkupContent(34, "\n            ");
            __builder.OpenComponent<MatBlazor.MatButton>(35);
            __builder.AddAttribute(36, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                CantGoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                                       _=>NextAppointment()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "\n                Next");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "columnAppointments");
            __builder.AddMarkupContent(45, "\n            ");
            __builder.OpenComponent<MatBlazor.MatButton>(46);
            __builder.AddAttribute(47, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                CantGoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                                       _=>GoToLast()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "\n                Last");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "mainColumnAppointments");
            __builder.AddMarkupContent(57, "\n        ");
            __builder.OpenComponent<DietMap.Client.Components.AppointmentDetails>(58);
            __builder.AddAttribute(59, "appointment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DietMap.Client.Classes.Appointment>(
#nullable restore
#line 45 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                        SelectedAppointment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "previousAppointment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DietMap.Client.Classes.Appointment>(
#nullable restore
#line 45 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
                                                                previousAppointment

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n");
#nullable restore
#line 47 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "\n");
            __builder.AddMarkupContent(64, "<style>\n.newAppointmentBtn{\n    margin-top: 40px;\n}\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/home/acid/Documents/projects/DietMap/DietMap.Client/Pages/Appointments.razor"
       

    [Parameter]
    public string ClientId {get;set;}
    [Parameter]
    public string ClientName {get;set;}
    public Appointment SelectedAppointment {get;set;}
    public Appointment previousAppointment {get;set;}

    private AppointmentList appointments;
    private bool CantGoBack{ get {
        return CurrentAppointmentIndex <= 0;
    }}
    private bool CantGoNext{ get {
        return CurrentAppointmentIndex >= FinalAppointment;
    }}
    private int CurrentAppointmentIndex { get {
        if (SelectedAppointment == null)
            return 0;
        return appointments.AppointmentsList.IndexOf(SelectedAppointment);
    }}
    
    void NewAppointment(){
        NavigationManager.NavigateTo($"/measurement/new");
    }
    async Task NextAppointment()
    {
        previousAppointment = null;
        await Task.Delay(10);

        previousAppointment = SelectedAppointment;
        SelectedAppointment = appointments.AppointmentsList[CurrentAppointmentIndex + 1];
        StateHasChanged();
    }
    async Task GoToLast()
    {
        previousAppointment = null;
        await Task.Delay(10);
        previousAppointment = SelectedAppointment;
        SelectedAppointment = appointments.AppointmentsList[FinalAppointment];
        StateHasChanged();
    }

    void PreviousAppointment()
    {
        previousAppointment = null;
        SelectedAppointment = appointments.AppointmentsList[CurrentAppointmentIndex - 1];
    }


    private int FinalAppointment {
        get{
            if (appointments == null)
                return 0;
            if (appointments.AppointmentsList == null)
                return 0;
            return appointments.AppointmentsList.Count - 1;
    }}

    protected override async Task OnInitializedAsync()
    {
        if(!string.IsNullOrEmpty(ClientId))
        {
            var appointmentRequest = await Http.GetStringAsync("sample-data/"+ClientId+".json");
            appointments = JsonConvert.DeserializeObject<AppointmentList>(appointmentRequest);
            if(appointments.AppointmentsList.Count != 0)
                SelectedAppointment = appointments.AppointmentsList[0];
        }
        else
        {
            appointments = null;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
