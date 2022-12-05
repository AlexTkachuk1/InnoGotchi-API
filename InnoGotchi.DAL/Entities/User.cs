namespace InnoGotchi.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string AvatarImg { get; set; }
        public string Passvord { get; set; }
        public virtual List<Farm> Farms { get; set; }
    }
}
