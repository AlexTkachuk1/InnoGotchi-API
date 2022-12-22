using InnoGotchi.DAL.Entities.Base;

namespace InnoGotchi.DAL.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AvatarImg { get; set; }
        public string Password { get; set; }
        public List<Farm> Farms { get; set; }
    }
}
