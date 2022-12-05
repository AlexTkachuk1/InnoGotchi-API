using InnoGotchi.BLL.DTO;
using InnoGotchi.WEB.Models;

namespace NLayerApp.WEB.Models
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string AvatarImg { get; set; }
        public virtual List<FarmViewModel> Farms { get; set; }
    }
}
