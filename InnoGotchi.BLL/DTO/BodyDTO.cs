namespace InnoGotchi.BLL.DTO
{
    public record BodyDTO
    {
        public string Eyes { get; init; }
        public string Nose { get; init; }
        public string Mouth { get; init; }
        public string BodyShape { get; init; }
        public PetDTO Owner { get; init; }
    }
}
