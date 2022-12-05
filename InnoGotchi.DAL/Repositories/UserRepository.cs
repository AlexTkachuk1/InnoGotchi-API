using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;
using System.Data.Entity;

namespace InnoGotchi.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private InnoGotchiDbContext db;

        public UserRepository(InnoGotchiDbContext context)
        {
            this.db = context;
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.SingleOrDefault(user => user.Id == id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }
    }
}