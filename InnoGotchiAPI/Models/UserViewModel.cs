namespace InnoGotchiAPI.Models
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IFormFile AvatarImg { get; set; }
        public virtual List<FarmViewModel> Farms { get; set; }
    }
}
