namespace AgenciaViajes.API.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public Client Client { get; set; }
        public int IdTravelPackage { get; set; }
        public TravelPackage TravelPackage { get; set; }
        public float Cost { get; set; }
    }
}