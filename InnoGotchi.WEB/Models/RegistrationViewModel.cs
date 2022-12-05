using InnoGotchi.BLL.DTO;

namespace InnoGotchi.WEB.Models
{
    public class RegistrationViewModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string AvatarImg { get; set; }
        public string Passvord { get; set; }
        public virtual List<FarmViewModel> Farms { get; set; }
    }
}
