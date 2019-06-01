using System.Threading.Tasks;
using CommandDispatcherDemo.Handlers;
using CommandDispatcherDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandDispatcherDemo.Controllers
{
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ICommandHandler<Request1, Response1> _handler1;
        private readonly ICommandHandler<Request2> _handler2;

        public DemoController(
            ICommandHandler<Request1, Response1> handler1,
            ICommandHandler<Request2> handler2)
        {
            _handler1 = handler1;
            _handler2 = handler2;
        }

        [HttpPost]
        [Route("/api/test1")]
        public async Task<Response1> Test1(Request1 request)
        {
            return await _handler1.HandleAsync(request);
        }

        [HttpPost]
        [Route("/api/test2")]
        public async Task Test2(Request2 request)
        {
            await _handler2.HandleAsync(request);
        }
    }
}
