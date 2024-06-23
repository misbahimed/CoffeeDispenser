using CoffeeDispenser.Domain.Models;

namespace CoffeeDispenser.Application.Application;

public class EspressoPriceCalculator : IPriceCalculator
{
    public decimal CalculatePrice(IEnumerable<RecipeLine> recipeLines)
    {
        throw new NotImplementedException();
    }
}
