using System.ComponentModel.DataAnnotations;

namespace Receptbas_ASPNET.Repository.Entities
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        [StringLength(100)]
        public string Title{ get; set; }

        [StringLength(500)]
        public string Ingredients { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

    }
}
