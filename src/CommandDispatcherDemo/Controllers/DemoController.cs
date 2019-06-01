using System.Threading.Tasks;
using CommandDispatcherDemo.Models;
using CommandDispatcherDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CommandDispatcherDemo.Controllers
{
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoService _demoService;

        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        [HttpPost]
        [Route("/api/test1")]
        public async Task<Response1> Test1(Request1 request)
        {
            return await _demoService.HandleRequest1(request);
        }

        [HttpPost]
        [Route("/api/test2")]
        public async Task Test2(Request2 request)
        {
            await _demoService.HandleRequest2(request);
        }
    }
}
