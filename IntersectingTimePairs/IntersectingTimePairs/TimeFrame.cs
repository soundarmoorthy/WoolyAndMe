using System;
namespace IntersectingTimePairs
{
    public class TimeFrame
    {
        private static int sequence = 1;
        public DateTime Start;
        public DateTime End;
        public int Id;

        private TimeFrame(int id)
        {
            this.Id = id;
        }

        public static TimeFrame Create(DateTime start, DateTime end)
        {
            return new TimeFrame(sequence++) { Start = start, End = end };
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Start.ToShortTimeString(), End.ToShortTimeString());
        }


        public bool Overlaps (TimeFrame other)
        {
            if (Object.ReferenceEquals(this, other))
               return false;

            if (other.Start > this.Start && other.Start < this.End)
                return true;

            else if (other.End < this.End && other.End > this.Start)
                return true;

            else
                return false;
        }
    }
}