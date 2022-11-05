namespace RecipesAPI.Models;

public sealed class User
{
    public int Id { get; set; }

    public string Name { get; set; } = "Name";

    public IEnumerable<Category> Categories { get; set; } = default!;
}
