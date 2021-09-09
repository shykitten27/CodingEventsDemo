using CodingEventsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Data
{
    public class EventData
    {
        //store events
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //retrieve the events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //retrieve a single event
        public static Event GetById(int id)
        {
            return Events[id]; //square brackets here
        }

        //remove an event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }
    }
}
