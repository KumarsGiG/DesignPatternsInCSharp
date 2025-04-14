namespace BehavioralDesignPattern_State
{
    #region ## STATE INTRODUCTION ##

    /// <summary>
    /// State is a behavioral design pattern that allows an object to change the behavior when its internal state changes.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            Console.ReadLine();
        }
    }
}
