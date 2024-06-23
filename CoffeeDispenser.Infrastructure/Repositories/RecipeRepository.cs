using CoffeeDispenser.Domain.Enums;
using CoffeeDispenser.Domain.Models;

namespace CoffeeDispenser.Infrastructure.Repositories;

public class RecipeRepository : IRecipeRepository
{
    public IEnumerable<RecipeLine>? GetRecipeLines(DrinkEnum drink)
    {
        return drink switch
        {
            DrinkEnum.Espresso => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 2
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Coffee),
                    Dose = 1
                }
            },
            DrinkEnum.Milk => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.MilkPowder),
                    Dose = 2
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 1
                }
            },
            DrinkEnum.Cappuccino => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.MilkPowder),
                    Dose = 2
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 1
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Coffee),
                    Dose = 1
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.ChocolatePowder),
                    Dose = 1
                }
            },
            DrinkEnum.HotChocolate => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 3
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.ChocolatePowder),
                    Dose = 2
                }
            },
            DrinkEnum.CoffeeWithMilk => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.MilkPowder),
                    Dose = 1
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 2
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Coffee),
                    Dose = 1
                }
            },
            DrinkEnum.Mokaccino => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.MilkPowder),
                    Dose = 1
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 2
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Coffee),
                    Dose = 1
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.ChocolatePowder),
                    Dose = 2
                },
            },
            DrinkEnum.Tea => new List<RecipeLine>
            {
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Water),
                    Dose = 2
                },
                new RecipeLine
                {
                    Ingredient = GetIngredientByName(IngredientEnum.Tea),
                    Dose = 1
                },
            },
            _ => null,
        };
    }

    private Ingredient GetIngredientByName(IngredientEnum ingredientName)
    {
        List<Ingredient> ingredients = new List<Ingredient>()
        {
            new Ingredient { Name = IngredientEnum.MilkPowder, PricePerDose = 10 },
            new Ingredient { Name = IngredientEnum.Coffee, PricePerDose = 30  },
            new Ingredient { Name = IngredientEnum.ChocolatePowder, PricePerDose = 40  },
            new Ingredient { Name = IngredientEnum.Tea, PricePerDose = 30  },
            new Ingredient { Name = IngredientEnum.Water, PricePerDose = 5 },
        };

        var ingredient = ingredients.FirstOrDefault(i => i.Name == ingredientName);

        if (ingredient == null)
            throw new ArgumentNullException("Ingredient not found");

        return ingredient;
    }
}