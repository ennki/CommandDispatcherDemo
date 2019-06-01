using System.Threading.Tasks;
using CommandDispatcherDemo.Models;

namespace CommandDispatcherDemo.Handlers
{
    public class Request1Handler : ICommandHandler<Request1, Response1>
    {
        public async Task<Response1> HandleAsync(Request1 request)
        {
            return await Task.FromResult(new Response1());
        }
    }
}
