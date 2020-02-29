using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdTravelPackage { get; set; }
        public float Cost { get; set; }
    }
}