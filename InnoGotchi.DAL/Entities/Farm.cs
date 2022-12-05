namespace InnoGotchi.DAL.Entities
{
    public class Farm
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<Pet> Pets { get; set; }
    }
}
