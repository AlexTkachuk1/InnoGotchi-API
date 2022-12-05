using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IBodyService
    {
        void CreateBody(Body body);
        void UpdateBody(Body body);
        void DeleteBody(int bodyId);
        Body GetBody(int bodyId);
        List<Body> GetAllBodys();
        void Dispose();
    }
}
