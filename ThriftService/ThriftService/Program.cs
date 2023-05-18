using Thrift.Server;
using Thrift.Transport;

namespace ThriftService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HelloWorldServer helloWorldServer = new HelloWorldServer();
                HelloWorld.Processor processor = new HelloWorld.Processor(helloWorldServer);
                TServerTransport serverTransport = new TServerSocket(9091);
                TServer server = new TSimpleServer(processor, serverTransport);
                Console.WriteLine("Starting the server...");
                server.Serve();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("done.");
        }
    }
}
