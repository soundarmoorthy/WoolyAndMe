using System;
using System.Collections.Generic;
using System.Linq;

namespace IntersectingTimePairs
{
    public static class TimeFrameGenerator
    {
        private static DateTime today;
        static Random r;
        static TimeFrameGenerator()
        {
            today = DateTime.Now;
            r = new Random(1);
        }

        public static IEnumerable<TimeFrame> Generate(uint count)
        {
            List<TimeFrame> list = new List<TimeFrame>();
            DateTime start, end;
            for (int i = 0; i < count; i++)
            {
                start = Start();
                end = End(start);
                list.Add(TimeFrame.Create(start, end));
            }
            return list.AsEnumerable();
        }

        private static DateTime Start()
        {
            int hour = r.Next(22);
            int minute = r.Next(0, 45);
            return new DateTime(today.Year, today.Month, today.Day, hour, minute, 0);
        }

        private static DateTime End(DateTime start)
        {
            int hour = r.Next(start.Hour, start.Hour + 1);
            int minute = 0;
            if (start.Hour == hour)
                minute = r.Next(start.Minute, 59);
            else
                minute = r.Next(0, 59);
            return new DateTime(today.Year, today.Month, today.Day, hour, minute, 0);
        }
    }
}