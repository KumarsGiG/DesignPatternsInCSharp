namespace BehavioralDesignPattern_Momento
{
    #region ## MOMENTO INTRODUCTION ##

    /// <summary>
    /// Memento is a behavioral design pattern that allows making 
    /// snapshots of an object’s state and restoring it in future.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // Client code.
            var originator = new Originator("Super-duper-super-puper-super.");
            var caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
