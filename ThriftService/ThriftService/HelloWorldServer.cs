using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftService
{
    class HelloWorldServer : HelloWorld.Iface
    {
        public string hello(string name)
        {
            Console.WriteLine(name + " ");
            return "Hola " + name + " eres un changuin"; 
        }
    }
}
