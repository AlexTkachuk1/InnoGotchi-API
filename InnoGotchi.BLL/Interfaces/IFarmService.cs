using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IFarmService
    {
        void CreateFarm(Farm farm);
        void UpdateFarm(Farm farm);
        void DeleteFarm(int farmId);
        Farm GetFarm(int farmId);
        List<Farm> GetAllFarms();
        void Dispose();
    }
}
