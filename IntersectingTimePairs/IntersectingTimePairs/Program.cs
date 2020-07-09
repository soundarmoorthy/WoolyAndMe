using System.Linq;
using System.Collections.Generic;
using System;

namespace IntersectingTimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //BruteForce bf = new BruteForce();
            //bf.Run();

            var timeFrames = TimeFrameGenerator.Generate(20);
            LinkedListApproach lla = new LinkedListApproach(timeFrames);
            lla.Run();


        }
    }
}