using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using GRPC.Core;

namespace GRPC.Server2.Services
{
    public class GreeterService : GreeterServer2.GreeterServer2Base
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply2> SayHello(HelloRequest2 request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply2
            {
                Message = "Hello " + request.Name + " From server 2"
            });
        }
    }
}
