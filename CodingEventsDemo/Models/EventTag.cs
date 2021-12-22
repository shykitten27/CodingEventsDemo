using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class EventTag 
    {
        //not Id field since the EventId AND TagId pair function as primary key 
        //since event and tag should only be related once
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public EventTag()
        {
        }
    }
}
