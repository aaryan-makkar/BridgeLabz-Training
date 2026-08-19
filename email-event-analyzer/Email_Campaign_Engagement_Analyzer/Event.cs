using System;

namespace Email_Campaign_Engagement_Analyzer
{
    public class Event
    {
        public string EventType { get; set; }
        public string Campaign { get; set; }
        public string UserEmail { get; set; }
        public DateTime Timestamp { get; set; }
        public string Device { get; set; }

        public Event()
        {
        }

        public Event(string eventType, string campaign, string userEmail,
                          DateTime timestamp, string device)
        {
            EventType = eventType;
            Campaign = campaign;
            UserEmail = userEmail;
            Timestamp = timestamp;
            Device = device;
        }

        public override string ToString()
        {
            return $"Event: {EventType}, Campaign: {Campaign}, User: {UserEmail}, Timestamp: {Timestamp}, Device: {Device}";
        }
    }
}