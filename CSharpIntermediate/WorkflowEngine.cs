namespace CSharpIntermediate
{
    partial class Program
    {
        public class WorkflowEngine
        {
            public static void Run(Workflow workflow)
            {
                foreach (var activity in workflow.Activities)
                {
                    activity.Execute();
                }
            }
        }
    }
}
