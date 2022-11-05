namespace RecipesAPI.DTOs;

public sealed record User
{
    public int Id { get; set; }

    public string Name { get; set; } = "Name";
}
