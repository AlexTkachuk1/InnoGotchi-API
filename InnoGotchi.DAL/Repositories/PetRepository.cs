using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;
using System.Data.Entity;

namespace InnoGotchi.DAL.Repositories
{
    public class PetRepository : IRepository<Pet>
    {
        private InnoGotchiDbContext db;

        public PetRepository(InnoGotchiDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Pet> GetAll()
        {
            return db.Pets;
        }

        public Pet Get(int id)
        {
            return db.Pets.Find(id);
        }

        public void Create(Pet pet)
        {
            db.Pets.Add(pet);
        }

        public void Update(Pet pet)
        {
            db.Entry(pet).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
        public IEnumerable<Pet> Find(Func<Pet, Boolean> predicate)
        {
            return db.Pets.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Pet pet = db.Pets.Find(id);
            if (pet != null)
                db.Pets.Remove(pet);
        }
    }
}
