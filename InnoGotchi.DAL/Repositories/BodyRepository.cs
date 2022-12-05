using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;
using System.Data.Entity;

namespace InnoGotchi.DAL.Repositories
{
    public class BodyRepository : IRepository<Body>
    {
        private InnoGotchiDbContext db;

        public BodyRepository(InnoGotchiDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Body> GetAll()
        {
            return db.Bodys;
        }

        public Body Get(int id)
        {
            return db.Bodys.Find(id);
        }

        public void Create(Body body)
        {
            db.Bodys.Add(body);
        }

        public void Update(Body body)
        {
            db.Entry(body).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
        public IEnumerable<Body> Find(Func<Body, Boolean> predicate)
        {
            return db.Bodys.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Body body = db.Bodys.Find(id);
            if (body != null)
                db.Bodys.Remove(body);
        }
    }
}
