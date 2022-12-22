using AutoMapper;
using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities.Base;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services.Base
{
    public class Service<T, D> : IService<T, D> where T : BaseEntity where D : class
    {
        IRepository<T> _repository { get; set; }
        IMapper _mapper { get; set; }
        public Service(
            IMapper mapper,
            IRepository<T> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Create(D entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            _repository.Insert(entity);
        }

        public void Update(D entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            _repository.Update(entity);
        }

        public void Delete(int entityId)
        {
            var entity = _repository.Get(entityId);
            _repository.Delete(entity);
        }

        public T Get(int entityId) => _repository.Get(entityId);

        public IEnumerable<T> GetAll() => _repository.GetAll();
    }
}
