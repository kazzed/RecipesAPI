namespace RecipesAPI.DTOs;

public sealed record Recipe
{
    public int Id { get; set; }

    public string Name { get; set; } = "New Recipe";

    public string Description { get; set; } = default!;

    public int CategoryId { get; set; }

    public int UserId { get; set; }

    public IEnumerable<Ingredient> Ingredients { get; set; } = default!;

    public IEnumerable<Direction> Directions { get; set; } = default!;
}
