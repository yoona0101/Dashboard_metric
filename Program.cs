using Dashboard_metric;
using Dashboard_metric.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Microsoft.AspNetCore.Builder;
using MudBlazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

/*var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();*/

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

/*builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {


            policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});*/
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();




//app.UseCors();


