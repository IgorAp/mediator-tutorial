using MediatorTutorial.Core.Messages.SharedMessages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorTutorial.ContextB.Application.Events
{
    public class EventExampleHandler : INotificationHandler<EventExample>
    {
        public Task Handle(EventExample notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.MyProperty);

            return Task.CompletedTask;
        }
    }
}
