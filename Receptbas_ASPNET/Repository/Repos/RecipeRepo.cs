using Receptbas_ASPNET.Repository.Entities;
using Receptbas_ASPNET.Repository.Interfaces;

namespace Receptbas_ASPNET.Repository.Repos
{
    public class RecipeRepo : IRecipeRepo
    {
        private readonly RecipeContext _recipeContext;

        public RecipeRepo(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }

        public void AddNewRecipe(Recipe recipe)
        {
            _recipeContext.Recipes.Add(recipe);
            _recipeContext.SaveChanges();
        }

        public List<Recipe> GetAllRecipes()
        {
            return _recipeContext.Recipes.ToList();
        }

        public Recipe GetRecipe(string? title)
        {
            return _recipeContext.Recipes.FirstOrDefault(s => s.Title.Contains(title));
        }
    }
}
