using CoffeShop.Domain.Enums;

namespace CoffeShop.Domain.Models;

public class Drink
{
    public DrinkEnum? Name { get; set; }
    public decimal Price { get; set; }
    public List<RecipeLine>? Recipe { get; set; }
}
