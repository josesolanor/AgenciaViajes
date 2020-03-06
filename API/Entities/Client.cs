using System.Collections.Generic;

namespace AgenciaViajes.Presentation.API.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Cellphone { get; set; }
        public List<Booking> TravelPackages { get; set; }
    }
}