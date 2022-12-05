using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;
using System.Data.Entity;

namespace InnoGotchi.DAL.Repositories
{
    public class FarmRepository : IRepository<Farm>
    {
        private InnoGotchiDbContext db;

        public FarmRepository(InnoGotchiDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Farm> GetAll()
        {
            return db.Farms;
        }

        public Farm Get(int id)
        {
            return db.Farms.Find(id);
        }

        public void Create(Farm farm)
        {
            db.Farms.Add(farm);
        }

        public void Update(Farm farm)
        {
            db.Entry(farm).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
        public IEnumerable<Farm> Find(Func<Farm, Boolean> predicate)
        {
            return db.Farms.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Farm farm = db.Farms.Find(id);
            if (farm != null)
                db.Farms.Remove(farm);
        }
    }
}
