using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetExtensions
{
    public static class IntExtensions
    {
        public static TimeSpan Days(this int number)
        {
            return new TimeSpan(days: number, hours: 0, minutes: 0, seconds: 0, milliseconds: 0);
        }

        public static TimeSpan Hours(this int number)
        {
            return new TimeSpan(hours: number, minutes: 0, seconds: 0);
        }

        public static TimeSpan Minutes(this int number)
        {
            return new TimeSpan(hours: 0, minutes: number, seconds: 0);
        }

        public static TimeSpan Seconds(this int number)
        {
            return new TimeSpan(hours: 0, minutes: 0, seconds: number);
        }

        public static TimeSpan Milliseconds(this int number)
        {
            return new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 0, milliseconds: number);
        }
    }
}
