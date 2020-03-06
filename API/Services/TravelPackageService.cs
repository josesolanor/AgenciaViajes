using System.Collections.Generic;
using System.Linq;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Data;
using AgenciaViajes.Presentation.API.Interfaces;

namespace AgenciaViajes.Presentation.API.Services
{
    public class TravelPackageService : ICRUDMethods<TravelPackage>
    {
        private readonly ApplicationDBContext _context;

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
            var result = _context.TravelPackages.ToList();
            return result;
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