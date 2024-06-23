using CoffeeDispenser.Domain.Enums;

namespace CoffeeDispenser.Domain.Models;

public class Drink
{
    public DrinkEnum? Name { get; set; }
    public decimal Price { get; set; }
    public List<RecipeLine>? Recipe { get; set; }
}
