global using BlazorEcommerceNET6.Shared;
global using BlazorEcommerceNET6.Shared.DTO;
global using System.Net.Http.Json;
global using BlazorEcommerceNET6.Client.Services.CartService;
global using BlazorEcommerceNET6.Client.Services.CategoryService;
global using BlazorEcommerceNET6.Client.Services.ProductService;
global using BlazorEcommerceNET6.Client.Services.AuthService;
using BlazorEcommerceNET6.Client;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorEcommerceNET6.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IAuthService, AuthService>();

            await builder.Build().RunAsync();
        }
    }
}