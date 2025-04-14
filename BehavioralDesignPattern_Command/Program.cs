namespace BehavioralDesignPattern_Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            var invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            var receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();

            Console.ReadLine();
        }
    }
}
