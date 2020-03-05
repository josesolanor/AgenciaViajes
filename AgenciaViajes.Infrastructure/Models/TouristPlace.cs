using System.Collections.Generic;

namespace AgenciaViajes.Infrastructure.Models
{
    public class TouristPlace : ValueObject
    {
        private TouristPlace()
        {
        }

        public TouristPlace(string name, string description)
        {
            NameTouristPlace = name;
            DescriptionTouristPlace = description;
        }

        public string NameTouristPlace { get; }

        public string DescriptionTouristPlace { get; }

        public override string ToString()
        {
            return $"{NameTouristPlace}, {DescriptionTouristPlace}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return NameTouristPlace;
            yield return DescriptionTouristPlace;
        }
    }
}