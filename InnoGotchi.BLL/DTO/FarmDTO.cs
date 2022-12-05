namespace InnoGotchi.BLL.DTO
{
    public class FarmDTO
    {
        public virtual List<UserDTO> Users { get; set; }
        public virtual List<PetDTO> Pets { get; set; }
    }
}
