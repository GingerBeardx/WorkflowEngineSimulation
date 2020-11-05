using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngineSimulation
{
    class VideoUpload : IActivity
    {
        public string Name { get; set; }
        public int VideoLength { get; set; }

        public VideoUpload(string name, int videoLength)
        {
            Name = name;
            VideoLength = videoLength;
        }
        public void Execute()
        {
            Console.WriteLine("Video Uploaded");
        }
    }
}
