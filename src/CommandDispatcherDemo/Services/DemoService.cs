using System.Threading.Tasks;
using CommandDispatcherDemo.Models;

namespace CommandDispatcherDemo.Services
{
    public class DemoService : IDemoService
    {
        public async Task<Response1> HandleRequest1(Request1 request)
        {
            return await Task.FromResult(new Response1());
        }

        public async Task HandleRequest2(Request2 request)
        {
            await Task.CompletedTask;
        }
    }
}
