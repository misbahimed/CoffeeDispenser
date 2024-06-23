using CoffeeDispenser.Domain.Enums;
using CoffeeDispenser.Domain.Models;
using CoffeeDispenser.Infrastructure.Repositories;

namespace CoffeeDispenser.Application.Services;

public class OrderService(IRecipeRepository _recipeRepository) : IOrderService
{
    public decimal CalculateDrinkPrice(DrinkEnum drink)
    {
        IEnumerable<RecipeLine>? recipeLines = _recipeRepository.GetRecipeLines(drink);

        if( recipeLines == null)
        {
            throw new ArgumentNullException("Drink not found");
        }

        decimal price = recipeLines.Sum(recipeLine => (recipeLine.Ingredient!.PricePerDose * 1.30m) * recipeLine.Dose);

        return price;
    }
}
