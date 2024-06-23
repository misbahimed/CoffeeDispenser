using CoffeeDispenser.Domain.Enums;

namespace CoffeeDispenser.Application.Services;

public interface IOrderService
{
    decimal CalculateDrinkPrice(DrinkEnum drink);
}
