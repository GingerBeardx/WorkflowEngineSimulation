using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngineSimulation
{
    class VideoEncoder : IActivity
    {
        public string Name { get; set; }
        public string EncodingType { get; set; }

        public VideoEncoder(string name, string encodingType)
        {
            Name = name;
            EncodingType = encodingType;
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Video encoding begun");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
