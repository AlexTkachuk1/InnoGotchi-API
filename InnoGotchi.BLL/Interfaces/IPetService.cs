using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IPetService
    {
        void CreatePet(Pet pet);
        void UpdatePet(Pet pet);
        void DeletePet(int petId);
        Pet GetPet(int petId);
        List<Pet> GetAllPets();
        void Dispose();
    }
}
