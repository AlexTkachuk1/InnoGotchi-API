using InnoGotchi.DAL.Entities;

namespace InnoGotchi.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Farm> Farms { get; }
        IRepository<Pet> Pets { get; }
        IRepository<Body> Bodys { get; }
        void Save();
    }
}
