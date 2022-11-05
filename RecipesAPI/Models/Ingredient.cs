namespace RecipesAPI.Models;

public sealed class Ingredient
{
    public int Id { get; set; }

    public string Description { get; set; } = default!;
}
