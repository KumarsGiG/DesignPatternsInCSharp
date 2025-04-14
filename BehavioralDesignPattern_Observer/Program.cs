namespace BehavioralDesignPattern_Observer
{
    #region ## OBSERVER INTRODUCTION ##

    /// <summary>
    /// Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
