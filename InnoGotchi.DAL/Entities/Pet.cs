using InnoGotchi.DAL.Entities.Base;

namespace InnoGotchi.DAL.Entities
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public bool Hungry { get; set; }
        public bool Dehydrated { get; set; }
        public Body Body { get; set; }
        public Farm Farm { get; set; }
    }
}
