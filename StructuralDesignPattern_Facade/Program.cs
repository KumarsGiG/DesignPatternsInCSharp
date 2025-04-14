namespace StructuralDesignPattern_Facade
{
    #region ## FACADE INTRODUCTION ##

    /// <summary>
    /// Facade is a structural design pattern that provides a simplified (but limited) 
    /// interface to a complex system of classes, library or framework.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);

            Console.ReadLine();
        }
    }
}
