using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services
{
    public class BodyService : IBodyService
    {
        IUnitOfWork Database { get; set; }

        public BodyService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreateBody(Body body)
        {
            Database.Bodys.Create(body);
        }

        public void UpdateBody(Body body)
        {
            Database.Bodys.Update(body);
        }

        public void DeleteBody(int bodyId)
        {
            Database.Bodys.Delete(bodyId);
        }

        public Body GetBody(int bodyId)
        {
            return Database.Bodys.Get(bodyId);
        }

        public List<Body> GetAllBodys()
        {
            return Database.Bodys.GetAll();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
