using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngineSimulation
{
    class DbStatusUpdate : IActivity
    {
        public string ConnectionString { get; set; }

        public DbStatusUpdate(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Execute()
        {
            Console.WriteLine("Database status updated to: Processing");
        }
    }
}
