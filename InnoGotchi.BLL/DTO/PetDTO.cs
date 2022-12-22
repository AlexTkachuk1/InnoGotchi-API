namespace InnoGotchi.BLL.DTO
{
    public record PetDTO
    {
        public string Name { get; init; }
        public bool Hungry { get; init; }
        public bool Dehydrated { get; init; }
        public virtual BodyDTO Body { get; init; }
        public virtual FarmDTO Farm { get; init; }
    }
}
