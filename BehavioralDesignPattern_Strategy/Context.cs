namespace BehavioralDesignPattern_Strategy
{
    // The Context defines the interface of interest to clients.
    public class Context
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IStrategy _strategy;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Context() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IStrategy strategy)
            => this._strategy = strategy;

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy)
            => this._strategy = strategy;

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });
            string resultStr = string.Empty;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Console.WriteLine(resultStr);
        }
    }
}
