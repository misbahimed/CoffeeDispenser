using CoffeeDispenser.Domain.Enums;
using CoffeeDispenser.Domain.Models;

namespace CoffeeDispenser.Infrastructure.Repositories;

public interface IRecipeRepository
{
    IEnumerable<RecipeLine>? GetRecipeLines(DrinkEnum drink);
}
