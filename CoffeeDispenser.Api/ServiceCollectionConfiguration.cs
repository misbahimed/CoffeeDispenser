using CoffeeDispenser.Application.Services;
using CoffeeDispenser.Infrastructure.Repositories;

namespace CoffeeDispenser.Api;

public static class ServiceCollectionConfiguration
{
    public static void Initialize(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();

        builder.Services.AddScoped<IOrderService, OrderService>();

    }
}
