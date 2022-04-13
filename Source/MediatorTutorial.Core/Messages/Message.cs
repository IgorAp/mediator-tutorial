using System;

namespace MediatorTutorial.Core.Messages
{
    public abstract class Message
    {
        public DateTime Timestamp { get; private set; }

        public Message()
        {
            Timestamp = DateTime.Now;
        }
    }
}
