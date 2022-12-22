using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services
{
    public class UserService : IUserService
    {
        IRepository<User> _userRepository { get; set; }
        IMapper _mapper { get; set; }
        public UserService(
            IMapper mapper,
            IRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public void Create(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            _userRepository.Insert(user);
        }

        public void Update(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            _userRepository.Update(user);
        }

        public void Delete(int userId)
        {
            var user = _userRepository.Get(userId);
            _userRepository.Delete(user);
        }

        public User Get(int userId) => _userRepository.Get(userId);

        public IEnumerable<User> GetAll() => _userRepository.GetAll();
    }
}
