using System.Threading.Tasks;
using CommandDispatcherDemo.Models;

namespace CommandDispatcherDemo.Handlers
{
    public class Request2Handler : ICommandHandler<Request2>
    {
        public async Task HandleAsync(Request2 request)
        {
            await Task.CompletedTask;
        }
    }
}
