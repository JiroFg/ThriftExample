using Thrift.Protocol;
using Thrift.Transport;

class Program
{
    static void Main(string[] args)
    {
        TTransport transport = new TSocket("localhost", 9091);
        transport.Open();
        TProtocol protocol = new TBinaryProtocol(transport);
        HelloWorld.Client client = new HelloWorld.Client(protocol);
        Console.WriteLine(client.hello("Pepito"));
    }
}
