using System.Threading.Tasks;

namespace CommandDispatcherDemo.Handlers
{
    public interface ICommandHandler<TRequest>
    {
        Task HandleAsync(TRequest request);
    }

    public interface ICommandHandler<TRequest, TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request);
    }
}
