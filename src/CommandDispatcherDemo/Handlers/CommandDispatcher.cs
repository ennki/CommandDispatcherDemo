using System;
using System.Threading.Tasks;

namespace CommandDispatcherDemo.Handlers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task DispatchAsync<TRequest>(TRequest request)
        {
            var handler = _serviceProvider.GetService(typeof(ICommandHandler<TRequest>)) as ICommandHandler<TRequest>;
            await handler.HandleAsync(request);
        }

        public async Task<TResponse> DispatchAsync<TRequest, TResponse>(TRequest request)
        {
            var handler = _serviceProvider.GetService(typeof(ICommandHandler<TRequest, TResponse>)) as ICommandHandler<TRequest, TResponse>;
            return await handler.HandleAsync(request);
        }
    }
}
