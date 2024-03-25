using Receptbas_ASPNET.Repository.Entities;
using Receptbas_ASPNET.Repository.Interfaces;

namespace Receptbas_ASPNET.Repository.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly RecipeContext _recipeContext;

        public UserRepo(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }

        public void CreateUser(User user)
        {
            _recipeContext.Users.Add(user);
            _recipeContext.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _recipeContext.Users.ToList();
        }

        public User Login(User user)
        {
            _recipeContext.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password);
            return user;
        }
    }
}
