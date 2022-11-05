using Microsoft.EntityFrameworkCore;
using RecipesAPI.Models;

namespace RecipesAPI.Data;

public sealed class RecipesContext : DbContext
{
    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options) { }

    public DbSet<Category> Categories { get; set; } = default!;
    public DbSet<Direction> Directions { get; set; } = default!;
    public DbSet<Ingredient> Ingredients { get; set; } = default!;
    public DbSet<Recipe> Recipes { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Recipe");
    }

}
