using MediatorTutorial.Core.Comunication.Mediator;
using MediatorTutorial.Core.Messages.SharedMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTutorial.ContextA.Application.Services
{
    public class ServiceA : IServiceA
    {
        private readonly IMediatorFacade _mediatorFacade;

        public ServiceA(IMediatorFacade mediatorFacade)
        {
            _mediatorFacade = mediatorFacade;
        }

        public async Task Execute()
        {
            await _mediatorFacade.Publish(new EventExample("Property from serviceA"));   
        }
    }
}
