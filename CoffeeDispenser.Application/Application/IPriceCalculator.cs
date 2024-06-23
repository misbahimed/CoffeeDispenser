using CoffeeDispenser.Domain.Models;

namespace CoffeeDispenser.Application.Application;

public interface IPriceCalculator
{
    decimal CalculatePrice(IEnumerable<RecipeLine> recipeLines);
}
