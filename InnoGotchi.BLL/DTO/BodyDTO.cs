namespace InnoGotchi.BLL.DTO
{
    public class BodyDTO
    {
        public string Eyes { get; set; }
        public string Nose { get; set; }
        public string Mouth { get; set; }
        public string BodyShape { get; set; }
        public virtual PetDTO Owner { get; set; }
    }
}
