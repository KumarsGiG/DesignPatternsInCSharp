namespace StructuralDesignPattern_Bridge
{
    #region ## BRIDGE INTRODUCTION ##

    /// <summary>
    /// Bridge is a structural design pattern that divides business logic
    /// or huge class into separate class hierarchies that can be developed independently.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);

            Console.ReadLine();
        }
    }
}
