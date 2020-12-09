using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using GRPC.Core;

namespace GRPC.Server1.Services
{
    public class GreeterService : GreeterServer1.GreeterServer1Base
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply1> SayHello(HelloRequest1 request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply1
            {
                Message = "Hello " + request.Name + " From server 1"
            });
        }
    }
}
