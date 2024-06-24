using CoffeShop.Domain.Enums;
using CoffeShop.Domain.Models;

namespace CoffeShop.Infrastructure.Repositories;

public interface IRecipeRepository
{
    IReadOnlyCollection<RecipeLine>? GetRecipeLines(DrinkEnum drink);
}
