#pragma checksum "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c062acbf6a652faef79f5e057918723228053ba4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using BlazorServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/piechart")]
    public partial class Piechart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\nPie series\r\n\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikChart>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartSeriesItems>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartSeries>(7);
                    __builder3.AddAttribute(8, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesType?>(
#nullable restore
#line 10 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
                           ChartSeriesType.Pie

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 10 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
                                                       _weathers22

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "ExplodeField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
                                                                                   nameof(DayCat.IsSeparated)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
                         nameof(DayCat.Days)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
                                                              nameof(DayCat.WeekDay)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n    \r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartTitle>(15);
                __builder2.AddAttribute(16, "Text", "Revenue per product");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartLegend>(18);
                __builder2.AddAttribute(19, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartLegendPosition?>(
#nullable restore
#line 18 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
                           ChartLegendPosition.Right

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Dan\RiderProjects\BlazorServerWeather\BlazorServer\Pages\Piechart.razor"
       

    List<WeatherDay> _weathers = new List<WeatherDay>();

    IEnumerable<DayCat> _weathers22 = null;
    
    public class DayCat
    {
        public String WeekDay { get; set; }
        public int Days { get; set; }

        public bool? IsSeparated
        {
            get
            { if (WeekDay == "Monday") return true; else return false; }
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await RefreshWeathers();
    }

    private async Task RefreshWeathers()
    {
        var weathers1 = await Service.GetWeatherAsync();
        var groupby = weathers1.GroupBy(a => a.WeekDay);

        _weathers22 = weathers1.GroupBy(x => x.WeekDay)
            .Select(y => new DayCat() {WeekDay = y.Key, Days = y.Count()});
        //_weathers22.First().IsSeparated = true;

    //var groupby22 = weathers1.GroupBy(a => a.WeekDay, 5);


    //var weathegroup = 
    }
    /*
    public class MyPieChartModel
    {
        public string SegmentName { get; set; }
        public double SegmentValue { get; set; }
    }
    

    public List<MyPieChartModel> pieData = new List<MyPieChartModel>
    {
        new MyPieChartModel
        {
            SegmentName = "Product 1",
            SegmentValue = 2
        },
        new MyPieChartModel
        {
            SegmentName = "Product 2",
            SegmentValue = 3
        },
        new MyPieChartModel
        {
            SegmentName = "Product 3",
            SegmentValue = 4
        }
    };
    */

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherServices Service { get; set; }
    }
}
#pragma warning restore 1591