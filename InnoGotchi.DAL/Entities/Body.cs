namespace InnoGotchi.DAL.Entities
{
    public class Body
    {
        public int Id { get; set; }
        public string Eyes { get; set; }
        public string Nose { get; set; }
        public string Mouth { get; set; }
        public string BodyShape { get; set; }
        public virtual int PetId { get; set; }
        public virtual Pet Owner { get; set; }
    }
}
