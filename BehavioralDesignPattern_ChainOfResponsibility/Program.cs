namespace BehavioralDesignPattern_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            //monkey.SetNext(squirrel).SetNext(dog);
            monkey.SetNext(dog).SetNext(squirrel);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Monkey > Dog > Squirrel\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Dog > Squirrel\n");
            Client.ClientCode(squirrel);

            Console.ReadLine();
        }
    }
}
