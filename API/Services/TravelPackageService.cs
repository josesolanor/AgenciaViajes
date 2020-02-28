using API.Context;
using API.Entities;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class TravelPackageService : ICRUDMethods<TravelPackage>
    {
        private ApplicationDBContext _context;

        public TravelPackageService(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(TravelPackage model)
        {
            _context.TravelPackages.Remove(model);
        }

        public List<TravelPackage> GetAll()
        {
            return _context.TravelPackages.ToList();
        }

        public TravelPackage GetById(int id)
        {
            return _context.TravelPackages.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Insert(TravelPackage model)
        {
            _context.TravelPackages.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TravelPackage model)
        {
            _context.TravelPackages.Update(model);
        }
    }
}
