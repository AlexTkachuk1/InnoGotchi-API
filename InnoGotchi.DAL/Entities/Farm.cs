using InnoGotchi.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoGotchi.DAL.Entities
{
    public class Farm : BaseEntity
    {
        public string Name { get; set; }

        [NotMapped]
        public User Creator { get; set; }
        public List<User> Visitors { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
