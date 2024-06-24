using CoffeShop.Domain.Enums;

namespace CoffeShop.Domain.Models;

public class Ingredient
{
    public IngredientEnum? Name { get; set; }
    public decimal PricePerDose { get; set; }
}
