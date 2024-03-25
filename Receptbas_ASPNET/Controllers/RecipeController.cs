using Microsoft.AspNetCore.Mvc;
using Receptbas_ASPNET.Repository.Entities;
using Receptbas_ASPNET.Repository.Interfaces;

namespace Receptbas_ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepo _recipeRepo;

        public RecipeController(IRecipeRepo recipeRepo)
        {
            _recipeRepo = recipeRepo;
        }

        [HttpGet]
        public IActionResult GetAllRecipes()
        {
            try
            {
                var recipes = _recipeRepo.GetAllRecipes();
                return Ok(recipes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{title}")]
        public IActionResult GetRecipe(string title)
        {
            var recipe = _recipeRepo.GetRecipe(title);
            return Ok(recipe);
        }

        [HttpPost]
        public IActionResult AddNewRecipe(Recipe recipe)
        {
            if (recipe == null)
                return BadRequest("Invalid parameters.");

            _recipeRepo.AddNewRecipe(recipe);
            return Created();
        }
    }
}
