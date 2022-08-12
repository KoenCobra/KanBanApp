using System.Reflection;
using Fluxor;
using KanBanApp;
using KanBanApp.Services;
using KanBanApp.Services.Abstractions;
using KanBanApp.Store;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(Assembly.GetExecutingAssembly());
    options.UseReduxDevTools();
});

builder.Services.AddScoped<IKanbanService, KanbanService>();
builder.Services.AddScoped<StateFacade>();

await builder.Build().RunAsync();