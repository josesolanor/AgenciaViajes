using System.Collections.Generic;

namespace AgenciaViajes.Presentation.API.Interfaces
{
    public interface ICRUDMethods<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T model);
        void Update(T model);
        void Delete(T model);
        void Save();
    }
}