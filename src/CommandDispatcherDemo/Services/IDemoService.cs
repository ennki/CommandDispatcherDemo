using System.Threading.Tasks;
using CommandDispatcherDemo.Models;

namespace CommandDispatcherDemo.Services
{
    public interface IDemoService
    {
        Task<Response1> HandleRequest1(Request1 request);

        Task HandleRequest2(Request2 request);
    }
}