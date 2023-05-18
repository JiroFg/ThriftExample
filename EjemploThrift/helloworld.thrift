namespace netstd ThriftService

service HelloWorld{
  string hello (1:string name);
}