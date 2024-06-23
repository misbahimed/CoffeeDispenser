using CoffeeDispenser.Application.Services;
using CoffeeDispenser.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeDispenser.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeDispenserController(IOrderService _orderService) : ControllerBase
{
    [HttpGet("price/{name}")]
    public IActionResult GetPrice(DrinkEnum name)
    {
        var response = _orderService.CalculateDrinkPrice(name);

        return Ok(response);
    }
}
