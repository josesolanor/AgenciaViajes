using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class TouristPlace : ValueObject
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        private TouristPlace() { }

        public TouristPlace(string name, string description)
        {
            this.Name = name;
            this.Description = description;            
        }

        public override string ToString()
        {
            return $"{Name}, {Description}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return Description;            
        }
    }
}
