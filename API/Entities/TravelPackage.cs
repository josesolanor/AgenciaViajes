﻿using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
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
