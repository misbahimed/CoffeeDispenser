using CoffeShop.Domain.Enums;

namespace CoffeShop.Application.Services;

public interface IOrderService
{
    decimal CalculateDrinkPrice(DrinkEnum drink);
}
