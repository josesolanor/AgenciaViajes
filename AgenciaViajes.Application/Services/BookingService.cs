using System.Collections.Generic;
using System.Linq;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Data;
using AgenciaViajes.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViajes.Application.Services
{
    public class BookingService : ICRUDMethods<Booking>
    {
        private readonly ApplicationDBContext _context;

        public BookingService(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(Booking model)
        {
            _context.Bookings.Remove(model);
        }

        public List<Booking> GetAll()
        {
            var result = _context.Bookings
                .Include(x => x.Client)
                .Include(x => x.TravelPackage)
                .ToList();

            return result;
        }

        public Booking GetById(int id)
        {
            return _context.Bookings
                .Include(x => x.Client)
                .Include(x => x.TravelPackage)
                .FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Insert(Booking model)
        {
            _context.Bookings.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Booking model)
        {
            _context.Bookings.Update(model);
        }
    }
}