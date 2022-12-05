using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        User GetUser(int userId);
        List<User> GetAllUsers();
        void Dispose();
    }
}
