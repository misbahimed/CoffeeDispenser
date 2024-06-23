using CoffeeDispenser.Domain.Enums;

namespace CoffeeDispenser.Domain.Models;

public class Ingredient
{
    public IngredientEnum? Name { get; set; }
    public decimal PricePerDose { get; set; }
}
