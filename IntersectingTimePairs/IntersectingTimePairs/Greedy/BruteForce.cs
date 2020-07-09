using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace IntersectingTimePairs
{
    public class BruteForce
    {
        TimeFrame[] timeFrames;
      public BruteForce(IEnumerable<TimeFrame> timeFrames)
        {
            this.timeFrames = timeFrames.ToArray();
        }

        public void Run()
        {
            uint n = 30;
            var dictionary = new Dictionary<int, List<TimeFrame>>((int)n);
            for (int i = 0; i < n; i++)
            {
                var reference = timeFrames[i];
                var list = new List<TimeFrame>();

                for (int j = 0; j < n; j++)
                {
                    var occurance = timeFrames[j];
                    if (occurance.Overlaps(reference))
                    {
                        list.Add(occurance);
                    }
                }
                if (!list.Any())
                    continue;

                list.Insert(0, reference);
                dictionary.Add(i, list);
            }
            foreach (var item in dictionary)
            {
                Console.Write(item.Key.ToString() + "\t[" + string.Join(",", item.Value) + "]");
                Console.WriteLine();
            }
        }
    }
}
