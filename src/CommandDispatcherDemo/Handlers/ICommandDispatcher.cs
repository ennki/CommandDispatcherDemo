using System.Threading.Tasks;

namespace CommandDispatcherDemo.Handlers
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TRequest>(TRequest request);

        Task<TResponse> DispatchAsync<TRequest, TResponse>(TRequest request);
    }
}
