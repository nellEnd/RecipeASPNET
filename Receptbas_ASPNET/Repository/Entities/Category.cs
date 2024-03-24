using System.ComponentModel.DataAnnotations;

namespace Receptbas_ASPNET.Repository.Entities
{
    public class Category
    {
        [Key]
        public  int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName {  get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
