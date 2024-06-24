using CoffeShop.Application.Services;
using CoffeShop.Infrastructure.Repositories;
using System.Text.Json.Serialization;

namespace CoffeShop.Api;

public static class ServiceCollectionConfiguration
{
    public static void Initialize(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();

        builder.Services.AddScoped<IOrderService, OrderService>();

        builder.Services
            .AddControllersWithViews()
            .AddJsonOptions(options =>
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

    }
}
