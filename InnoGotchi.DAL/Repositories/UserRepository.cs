using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;
using System.Data.Entity;

namespace InnoGotchi.DAL.Repositories
{
    internal class UserRepository : IRepository<User>
    {
        private InnoGotchiDbContext db;

    public UserRepository(InnoGotchiDbContext context)
    {
        this.db = context;
    }

    public IEnumerable<User> GetAll()
    {
        return db.Users;
    }

    public User Get(int id)
    {
        return db.Users.Find(id);
    }

    public void Create(User order)
    {
        db.Users.Add(order);
    }

    public void Update(User order)
    {
        db.Entry(order).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
    }
    public IEnumerable<User> Find(Func<User, Boolean> predicate)
    {
        return db.Users.Where(predicate).ToList();
    }
    public void Delete(int id)
    {
        User order = db.Users.Find(id);
        if (order != null)
            db.Users.Remove(order);
    }
}
}
