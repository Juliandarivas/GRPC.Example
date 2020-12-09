using System;
using System.Threading.Tasks;
using GRPC.Core;
using Grpc.Net.Client;

namespace GRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {

            using var channelSvr1 = GrpcChannel.ForAddress("https://localhost:5001");
            var clientSvr1 = new GreeterServer1.GreeterServer1Client(channelSvr1);
            var replySvr1 = await clientSvr1.SayHelloAsync(
                new HelloRequest1 { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + replySvr1.Message);

            using var channelSvr2 = GrpcChannel.ForAddress("https://localhost:6001");
            var clientSvr2 = new GreeterServer2.GreeterServer2Client(channelSvr2);
            var replySvr2 = await clientSvr2.SayHelloAsync(
                new HelloRequest2 { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + replySvr2.Message);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
