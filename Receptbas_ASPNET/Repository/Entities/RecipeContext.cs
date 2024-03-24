using Microsoft.EntityFrameworkCore;

namespace Receptbas_ASPNET.Repository.Entities
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }

        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
