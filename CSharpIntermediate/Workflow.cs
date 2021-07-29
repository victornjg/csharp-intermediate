using System.Collections.Generic;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class Workflow
        {
            public readonly List<IActivity> Activities = new List<IActivity>();

            public Workflow(List<IActivity> activities)
            {
                Activities.AddRange(activities);
            }
        }
    }
}
