namespace InnoGotchi.BLL.DTO
{
    public record UserDTO
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string AvatarImg { get; init; }
        public string Password { get; init; }
        public List<FarmDTO> Farms { get; init; }
    }
}
