using MediatorTutorial.Core.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTutorial.Core.Comunication.Mediator
{
    public interface IMediatorFacade
    {
        Task<bool> Send<T>(T command) where T : Command;
        Task Publish<T>(T notification) where T : Event;
    }

    public class MediatorFacade : IMediatorFacade
    {
        private readonly IMediator _mediator;

        public MediatorFacade(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Publish<T>(T notification) where T : Event
        {
            await _mediator.Publish(notification);
        }

        public async Task<bool> Send<T>(T command) where T : Command
        {
            return await _mediator.Send(command);
        }
    }
}
