using Receptbas_ASPNET.Repository.Entities;

namespace Receptbas_ASPNET.Repository.Interfaces
{
    public interface IUserRepo
    {
        void CreateUser(User user);

        List <User> GetUsers();

        public User Login(User user);
    }
}
