using System;

namespace Mews.Eet
{
    public class DateTimeWithTimeZone
    {
        public readonly static TimeZoneInfo CzechTimeZone;
        
        static DateTimeWithTimeZone()
        {
            try
            {
                CzechTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            }
            catch
            {
                CzechTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Prague");
            }
        }

        public DateTimeWithTimeZone(DateTime dateTime, TimeZoneInfo timezoneInfo)
        {
            DateTime = dateTime;
            TimeZoneInfo = timezoneInfo;
        }

        public DateTime DateTime { get; }

        public TimeZoneInfo TimeZoneInfo { get; }
    }
}
