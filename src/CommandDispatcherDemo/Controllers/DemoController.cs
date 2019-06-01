using System.Threading.Tasks;
using CommandDispatcherDemo.Handlers;
using CommandDispatcherDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandDispatcherDemo.Controllers
{
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ICommandDispatcher _dispatcher;

        public DemoController(ICommandDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        [Route("/api/test1")]
        public async Task<Response1> Test1(Request1 request)
        {
            return await _dispatcher.DispatchAsync<Request1, Response1>(request);
        }

        [HttpPost]
        [Route("/api/test2")]
        public async Task Test2(Request2 request)
        {
            await _dispatcher.DispatchAsync(request);
        }
    }
}
