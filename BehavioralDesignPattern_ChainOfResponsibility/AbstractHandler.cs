namespace BehavioralDesignPattern_ChainOfResponsibility
{
    // The default chaining behavior can be implemented inside a base handler class
    abstract class AbstractHandler : IHandler
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        private IHandler _nextHandler;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object? Handle(object request)
        {
            if (this._nextHandler != null)
                return this._nextHandler.Handle(request);
            else
                return null;
        }
    }
}
