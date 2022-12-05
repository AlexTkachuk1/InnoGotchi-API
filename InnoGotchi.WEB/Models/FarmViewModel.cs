using NLayerApp.WEB.Models;

namespace InnoGotchi.WEB.Models
{
    public class FarmViewModel
    {
        public virtual List<UserViewModel> Users { get; set; }
        public virtual List<PetViewModel> Pets { get; set; }
    }
}
