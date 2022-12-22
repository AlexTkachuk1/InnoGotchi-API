using InnoGotchi.BLL.DTO;

namespace InnoGotchiAPI.Models
{
    public class FarmViewModel
    {
        public string Name { get; set; }
        public UserViewModel Creator { get; set; }
        public List<UserViewModel> Visitors { get; set; }
        public List<PetViewModel> Pets { get; set; }
    }
}
