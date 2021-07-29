using System.Collections.Generic;

namespace CSharpIntermediate
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow(
                new List<IActivity>() { 
                    new UploadVideo(), 
                    new CallThirdPartyEncodingService(), 
                    new SendEmail(), 
                    new UpdateVideoRecordOnDatabase() 
                });
            WorkflowEngine.Run(workflow);
        }
    }
}
