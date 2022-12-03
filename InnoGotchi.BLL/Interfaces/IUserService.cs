using InnoGotchi.BLL.DTO;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IUserService
    {
        void CreateUser(UserDTO userDto);
        void Dispose();
    }
}
