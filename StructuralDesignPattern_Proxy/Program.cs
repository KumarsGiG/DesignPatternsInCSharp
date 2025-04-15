namespace StructuralDesignPattern_Proxy
{
    #region ## PROXY INTRODUCTION ##

    /// <summary>
    /// Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. 
    /// A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            var realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            var proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            Console.ReadLine();
        }
    }
}
