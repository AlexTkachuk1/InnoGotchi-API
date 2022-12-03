using InnoGotchi.DAL.Entities;

namespace InnoGotchi.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        void Save();
    }
}
