﻿using System.ComponentModel.DataAnnotations;

namespace Receptbas_ASPNET.Repository.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set;}
    }
}
