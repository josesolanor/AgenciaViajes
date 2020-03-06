using System;

namespace AgenciaViajes.Application.Models
{
    public class TravelPackageData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Fecha { get; set; }
        public string Type { get; set; }
        public TouristPlaceForTravelPackage TouristPlace { get; set; }
    }

    public class TouristPlaceForTravelPackage
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}