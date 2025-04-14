namespace StructuralDesignPattern_Decorator
{
    #region ## DECORATOR INTRODUCTION ##

    /// <summary>
    /// Decorator is a structural pattern that allows adding new behaviors to objects dynamically
    /// by placing them inside special wrapper objects, called decorators.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            var decorator1 = new ConcreteDecoratorA(simple);
            var decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);

            Console.ReadLine();
        }
    }
}
