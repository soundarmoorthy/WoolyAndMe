using System;
using System.Collections;
using System.Collections.Generic;
using IntersectingTimePairs.DynamicProgramming;
using System.Xml.Linq;
using System.Threading.Tasks.Dataflow;
using System.Linq;
namespace IntersectingTimePairs
{
    public class LinkedListApproach
    {
        private Node root;
        private readonly IEnumerable<TimeFrame> timeFrames;
        public LinkedListApproach(IEnumerable<TimeFrame> timeFrames)
        {
            this.timeFrames = timeFrames;
        }

        public void Run()
        {
            MakeList();

            var timeSlots = new Stack<Node>();
            timeSlots.Push(root);
            var runner = root.Next;
            while(runner != null)
            {
                if (timeSlots.Peek().Id == runner.Id)
                    timeSlots.Pop();
            }
        }

        private void MakeList()
        {
            foreach (var node in nodes())
            {
                if (root == null)
                {
                    root = node;
                    root.Next = null;
                    continue;
                }

                Node runner = root;
                if (root.Time > node.Time) //Insertion at beginning is tricky. We need to update root.
                {
                    node.Next = root;
                    root = node;
                    continue;
                }

                while (runner.Next != null && runner.Next.Time <= node.Time)//ook ahead to identify insertion point.
                {
                    runner = runner.Next;
                }
                node.Next = runner.Next;
                runner.Next = node;
            }
        }

        private IEnumerable<Node> nodes()
        {
            if (!timeFrames.Any())
                yield break;

            foreach (var timeFrame in timeFrames)
            {
                yield return new Node() { Id = timeFrame.Id, Time = timeFrame.Start };
                yield return new Node() { Id = timeFrame.Id, Time = timeFrame.End };
            }

        } 
    }
}