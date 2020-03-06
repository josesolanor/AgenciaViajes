using System;
using System.Collections.Generic;

namespace AgenciaViajes.Domain.Entities
{
    public class TravelPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Fecha { get; set; }
        public string Type { get; set; }
        public TouristPlace TouristPlace { get; set; }
        public List<Booking> Clients { get; set; }
    }
}