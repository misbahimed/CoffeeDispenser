using CoffeShop.Application.Services;
using CoffeShop.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DrinksController(IOrderService _orderService) : ControllerBase
{
    [HttpGet("{name}/price")]
    public IResult GetPrice(DrinkEnum name)
    {

        try
        {
            var response = _orderService.CalculateDrinkPrice(name);
            return Results.Ok(response);
        }
        catch (Exception)
        {
            return Results.NotFound();
        }
    }
}
