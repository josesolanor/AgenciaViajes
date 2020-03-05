using System;
using System.Collections.Generic;
using System.Linq;
using API.Context;
using API.Entities;
using API.Interfaces;

namespace API.Services
{
    public class ClientService : ICRUDMethods<Client>
    {
        private readonly ApplicationDBContext _context;

        public ClientService(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(Client model)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Client model)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Client model)
        {
            throw new NotImplementedException();
        }
    }
}