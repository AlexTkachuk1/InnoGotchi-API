﻿using InnoGotchi.DAL.Entities.Base;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IService<T, D> where T : BaseEntity where D : class
    {
        void Create(D entityDTO);
        void Update(D entityDTO);
        void Delete(int entityId);
        T Get(int entityId);
        IEnumerable<T> GetAll();
    }
}
