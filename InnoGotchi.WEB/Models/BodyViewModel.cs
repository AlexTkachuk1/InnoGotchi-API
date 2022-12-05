namespace InnoGotchi.WEB.Models
{
    public class BodyViewModel
    {
        public string Eyes { get; set; }
        public string Nose { get; set; }
        public string Mouth { get; set; }
        public string BodyShape { get; set; }
        public virtual PetViewModel Owner { get; set; }
    }
}
