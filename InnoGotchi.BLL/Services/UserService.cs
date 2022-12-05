using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreateUser(User user)
        {
            Database.Users.Create(user);
        }

        public void UpdateUser(User user)
        {
            Database.Users.Update(user);
        }

        public void DeleteUser(int userId)
        {
            Database.Users.Delete(userId);
        }

        public User GetUser(int userId)
        {
            return Database.Users.Get(userId);
        }

        public List<User> GetAllUsers()
        {
            return Database.Users.GetAll();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
