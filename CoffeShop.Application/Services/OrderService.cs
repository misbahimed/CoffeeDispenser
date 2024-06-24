using CoffeShop.Domain.Enums;
using CoffeShop.Domain.Models;
using CoffeShop.Infrastructure.Repositories;

namespace CoffeShop.Application.Services;

public class OrderService(IRecipeRepository _recipeRepository) : IOrderService
{
    public decimal CalculateDrinkPrice(DrinkEnum drink)
    {
        IReadOnlyCollection<RecipeLine>? recipeLines = _recipeRepository.GetRecipeLines(drink);
        decimal margin = 1.30m;

        if( recipeLines == null)
        {
            throw new ArgumentNullException("Drink not found");
        }

        decimal price = recipeLines.Sum(recipeLine => (recipeLine.Ingredient!.PricePerDose ) * recipeLine.Dose);

        return price * margin;
    }
}
