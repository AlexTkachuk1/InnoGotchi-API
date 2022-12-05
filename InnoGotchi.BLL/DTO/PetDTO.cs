namespace InnoGotchi.BLL.DTO
{
    public class PetDTO
    {
        public string Name { get; set; }
        public bool Hungry { get; set; }
        public bool WantsToDrink { get; set; }
        public virtual BodyDTO Body { get; set; }
        public virtual FarmDTO Farm { get; set; }
    }
}
