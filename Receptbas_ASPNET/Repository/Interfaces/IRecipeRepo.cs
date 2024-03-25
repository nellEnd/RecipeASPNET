using Receptbas_ASPNET.Repository.Entities;

namespace Receptbas_ASPNET.Repository.Interfaces
{
    public interface IRecipeRepo
    {
        void AddNewRecipe(Recipe recipe);

        List<Recipe> GetAllRecipes();

        public Recipe GetRecipe(string? title);
    }
}
