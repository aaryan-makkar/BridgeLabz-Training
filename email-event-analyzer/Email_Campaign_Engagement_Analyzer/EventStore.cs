using System;
using System.Collections.Generic;
using System.Text;

namespace Email_Campaign_Engagement_Analyzer
{
    public class EventStore<T>
    {
        private List<T> events;

        public EventStore()
        {
            events = new List<T>();
        }
        public void Add(T item)
        {
            events.Add(item);
        }

        public List<T> GetAll()
        {
            return events;
        }

        public int Count()
        {
            return events.Count;
        }
    }
}
