using InnoGotchi.DAL.Entities.Base;

namespace InnoGotchi.DAL.Entities
{
    public class Body : BaseEntity
    {
        public string Eyes { get; set; }
        public string Nose { get; set; }
        public string Mouth { get; set; }
        public string BodyShape { get; set; }
        public int PetId { get; set; }
        public Pet Owner { get; set; }
    }
}
