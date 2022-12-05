namespace InnoGotchi.WEB.Models
{
    public class PetViewModel
    {
        public string Name { get; set; }
        public bool Hungry { get; set; }
        public bool WantsToDrink { get; set; }
        public virtual BodyViewModel Body { get; set; }
        public virtual FarmViewModel Farm { get; set; }
    }
}
