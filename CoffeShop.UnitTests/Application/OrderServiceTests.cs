using AutoFixture;
using CoffeShop.Application.Services;
using CoffeShop.Domain.Enums;
using CoffeShop.Infrastructure.Repositories;
using FluentAssertions;
using NSubstitute;

namespace CoffeShop.UnitTests.Application;

public class OrderServiceTests
{
    private readonly Fixture _fixture;
    private readonly IOrderService _orderService;
    private readonly IRecipeRepository _recipeRepository;


    public OrderServiceTests()
    {
        _fixture = new Fixture();

        _recipeRepository = Substitute.For<RecipeRepository>();
        _fixture.Inject(_recipeRepository);

        _orderService = _fixture.Freeze<OrderService>();
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_52_When_Drink_Is_Espresso()
    {
        DrinkEnum drink = DrinkEnum.Espresso;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(0.52m);
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_325_When_Drink_Is_Milk()
    {
        DrinkEnum drink = DrinkEnum.Milk;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(0.325m);
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_1235_When_Drink_Is_Cappuccino()
    {
        DrinkEnum drink = DrinkEnum.Cappuccino;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(1.235m);
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_1235_When_Drink_Is_HotChocolate()
    {
        DrinkEnum drink = DrinkEnum.HotChocolate;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(1.2350m);
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_65_When_Drink_Is_CoffeeWithMilk()
    {
        DrinkEnum drink = DrinkEnum.CoffeeWithMilk;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(0.65m);
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_169_When_Drink_Is_Mokaccino()
    {
        DrinkEnum drink = DrinkEnum.Mokaccino;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(1.690m);
    }

    [Fact]
    public async Task CalculateDrinkPrice_Should_Return_52_When_Drink_Is_Tea()
    {
        DrinkEnum drink = DrinkEnum.Tea;

        var result = _orderService.CalculateDrinkPrice(drink);

        result.Should().Be(0.52m);
    }
}
