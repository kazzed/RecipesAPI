namespace RecipesAPI.DTOs;

public sealed record Direction
{
    public int Id { get; set; }

    public int Step { get; set; }

    public string DirectionText { get; set; } = default!;
}
