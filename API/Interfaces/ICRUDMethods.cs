using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
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
