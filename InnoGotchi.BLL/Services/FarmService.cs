using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services
{
    public class FarmService: IFarmService
    {
        IUnitOfWork Database { get; set; }

        public FarmService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreateFarm(Farm farm)
        {
            Database.Farms.Create(farm);
        }

        public void UpdateFarm(Farm farm)
        {
            Database.Farms.Update(farm);
        }

        public void DeleteFarm(int farmId)
        {
            Database.Farms.Delete(farmId);
        }

        public Farm GetFarm(int farmId)
        {
            return Database.Farms.Get(farmId);
        }

        public List<Farm> GetAllFarms()
        {
            return Database.Farms.GetAll();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
