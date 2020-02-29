using API.Context;
using API.Entities;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class ClientService : ICRUDMethods<Entities.Client>
    {
        private readonly ApplicationDBContext _context;

        public ClientService(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(Entities.Client model)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Client> GetAll()
        {
            return _context.Clients.ToList(); //please
        }

        public Entities.Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entities.Client model)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Client model)
        {
            throw new NotImplementedException();
        }
    }
}
