using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class TouristPlace : ValueObject
    {
        public string NameTouristPlace { get; private set; }

        public string DescriptionTouristPlace { get; private set; }

        private TouristPlace() { }

        public TouristPlace(string name, string description)
        {
            NameTouristPlace = name;
            DescriptionTouristPlace = description;            
        }

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
