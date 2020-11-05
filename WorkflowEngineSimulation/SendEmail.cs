using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngineSimulation
{
    class SendEmail : IActivity
    {
        public string Subject { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }

        public SendEmail(string subject, string recipient, string message)
        {
            Subject = subject;
            Recipient = recipient;
            Message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Recipient: {Recipient}");
            Console.WriteLine("Proessing notification emailed");
        }
    }
}
