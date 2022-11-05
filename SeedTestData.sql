INSERT INTO Recipe.Users (Name) VALUES ('Michael')
;
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [RecipesApp].[Recipe].[Users];

  
INSERT INTO Recipe.Categories ([Description], UserId) VALUES ('Poultry', 1)
;
SELECT TOP (1000) [Id]
      ,[Description]
      ,[UserId]
  FROM [RecipesApp].[Recipe].[Categories];
  
  
INSERT INTO Recipe.Recipes (Name, [Description], CategoryId, UserId) VALUES ('Chicken with White Wine Sauce', 'A classic pan sauce for chicken.', 1, 1)
;
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Description]
      ,[CategoryId]
      ,[UserId]
  FROM [RecipesApp].[Recipe].[Recipes]
  
  
INSERT INTO Recipe.Ingredients ([Description], RecipeId)
VALUES
('2 chicken breasts', 1),
('1/4 cup white wine', 1),
('1/2 cup chicken stock', 1),
('1/2 onion, finely diced', 1),
('1 tbsp butter', 1),
('fresh herbs: thyme, rosemary, and sage', 1),
('salt and pepper', 1),
('2 tsp oil', 1)
;
SELECT TOP (1000) [Id]
      ,[Description]
      ,[RecipeId]
  FROM [RecipesApp].[Recipe].[Ingredients]
  
  
INSERT INTO Recipe.Directions (SortOrder, DirectionText, RecipeId)
VALUES
(1, 'Test Directions Step 1', 1),
(2, 'Test Directions Step 2', 1)
;
SELECT TOP (1000) [Id]
      ,[SortOrder]
      ,[DirectionText]
      ,[RecipeId]
  FROM [RecipesApp].[Recipe].[Directions]