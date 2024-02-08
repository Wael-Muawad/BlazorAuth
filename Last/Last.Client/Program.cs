using Last.Client.Utils;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.RegisterServices();

await builder.Build().RunAsync();
