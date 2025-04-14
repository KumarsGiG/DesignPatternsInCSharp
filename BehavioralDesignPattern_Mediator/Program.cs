namespace BehavioralDesignPattern_Mediator
{
    #region ## Introduction ##

    /// <summary>
    /// Mediator is a behavioral design pattern that reduces coupling
    /// between components of a program by making them communicate indirectly, 
    /// through a special mediator object.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var component1 = new Component1();
            var component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();

            Console.ReadLine();
        }
    }
}
