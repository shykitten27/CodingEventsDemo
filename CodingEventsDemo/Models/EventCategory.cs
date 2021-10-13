using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public EventCategory()
        {
        }

        public EventCategory(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is EventCategory @eventCategory &&
                   Id == @eventCategory.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
