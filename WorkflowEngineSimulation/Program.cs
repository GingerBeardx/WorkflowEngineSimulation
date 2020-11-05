using System;

namespace WorkflowEngineSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();
            workflow.Run();
        }
    }
}
