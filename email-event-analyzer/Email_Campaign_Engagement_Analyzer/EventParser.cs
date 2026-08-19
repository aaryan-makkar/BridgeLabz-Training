using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Email_Campaign_Engagement_Analyzer
{
    public class EventParser
    {
        private const string Pattern = @"EVENT:(?<event>\w+)\|CAMPAIGN:(?<campaign>[^|]+)\|USER:(?<user>[^|]+)\|TS:(?<timestamp>[^|]+)\|DEVICE:(?<device>[^|]+)";
        public Event Parse(string record)
        {
            Match match = Regex.Match(record, Pattern);

            Event emailEvent = new Event()
            {
                EventType = match.Groups["event"].Value,
                Campaign = match.Groups["campaign"].Value,
                UserEmail = match.Groups["user"].Value,
                Timestamp = Convert.ToDateTime(match.Groups["timestamp"].Value),
                Device = match.Groups["device"].Value
            };

            return emailEvent;
        }
    }
}
