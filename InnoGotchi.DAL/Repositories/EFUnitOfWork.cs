using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private InnoGotchiDbContext db;
        private UserRepository userRepository;
        private FarmRepository farmRepository;
        private PetRepository petRepository;
        private BodyRepository bodyRepository;

        public EFUnitOfWork(InnoGotchiDbContext innoGotchiDbContext)
        {
            db = innoGotchiDbContext;
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public IRepository<Farm> Farms
        {
            get
            {
                if (farmRepository == null)
                    farmRepository = new FarmRepository(db);
                return farmRepository;
            }
        }
        public IRepository<Pet> Pets
        {
            get
            {
                if (petRepository == null)
                    petRepository = new PetRepository(db);
                return petRepository;
            }
        }
        public IRepository<Body> Bodys
        {
            get
            {
                if (bodyRepository == null)
                    bodyRepository = new BodyRepository(db);
                return bodyRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
