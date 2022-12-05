using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services
{
    public class PetService: IPetService
    {
        IUnitOfWork Database { get; set; }

        public PetService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreatePet(Pet pet)
        {
            Database.Pets.Create(pet);
        }

        public void UpdatePet(Pet pet)
        {
            Database.Pets.Update(pet);
        }

        public void DeletePet(int petId)
        {
            Database.Pets.Delete(petId);
        }

        public Pet GetPet(int petId)
        {
            return Database.Pets.Get(petId);
        }

        public List<Pet> GetAllPets()
        {
            return Database.Pets.GetAll();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
