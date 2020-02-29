using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BookingData
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public Client Client { get; set; }
        public int IdTravelPackage { get; set; }
        public TravelPackage TravelPackage { get; set; }
        public float Cost { get; set; }
    }
}
