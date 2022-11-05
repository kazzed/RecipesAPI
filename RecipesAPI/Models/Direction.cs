namespace RecipesAPI.Models;

public sealed class Direction
{
    public int Id { get; set; }

    public int SortOrder { get; set; }

    public string DirectionText { get; set; } = default!;
}
