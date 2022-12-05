namespace InnoGotchi.DAL.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Hungry { get; set; }
        public bool WantsToDrink { get; set; }
        public virtual Body Body { get; set; }
        public virtual Farm Farm { get; set; }
    }
}
