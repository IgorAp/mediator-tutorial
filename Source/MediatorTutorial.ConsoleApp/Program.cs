using MediatorTutorial.ContextA.Application.Services;
using MediatorTutorial.ContextB.Application.Events;
using MediatorTutorial.Core.Comunication.Mediator;
using MediatorTutorial.Core.Messages.SharedMessages;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace MediatorTutorial.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = GetServiceProvider();
            var serviceA = serviceProvider.GetService<IServiceA>();

            await serviceA.Execute();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddMediatR(typeof(Program));
            services.AddScoped<IMediatorFacade, MediatorFacade>();
            services.AddScoped<INotificationHandler<EventExample>, EventExampleHandler>();
            services.AddScoped<IServiceA, ServiceA>();
        }

        private static ServiceProvider GetServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }
    }
}
