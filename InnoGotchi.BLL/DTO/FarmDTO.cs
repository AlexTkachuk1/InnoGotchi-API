namespace InnoGotchi.BLL.DTO
{
    public record FarmDTO
    {
        public string Name { get; init; }
        public UserDTO Creator { get; init; }
        public List<UserDTO> Visitors { get; init; }
        public List<PetDTO> Pets { get; init; }
    }
}
