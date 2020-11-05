using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngineSimulation
{
    class WorkflowEngine
    {
        public List<IActivity> Activities { get; set; } = new List<IActivity>();

        public WorkflowEngine()
        {
            Activities.Add(new VideoUpload("My First Video", 15));
            Activities.Add(new VideoEncoder("My first video", "Standard"));
            Activities.Add(new SendEmail("Video Encoding Ready", "echo@nowhere.com", "Your video has been recieved and is being encoded."));
            Activities.Add(new DbStatusUpdate("ConnectMe"));

            foreach (var activity in Activities)
            {
                activity.Execute();
            }
        }
    }
}
