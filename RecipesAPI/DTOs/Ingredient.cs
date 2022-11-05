namespace RecipesAPI.DTOs;

public sealed record Ingredient
{
    public int Id { get; set; }

    public string Description { get; set; } = default!;
}
