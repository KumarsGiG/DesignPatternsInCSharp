namespace BehavioralDesignPattern_Momento
{
    // The Caretaker doesn't depend on the Concrete Memento class. Therefore, it
    // doesn't have access to the originator's state, stored inside the memento.
    // It works with all mementos via the base Memento interface.
    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        private Originator _originator = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        public Caretaker(Originator originator)
            => this._originator = originator;

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this._mementos.Add(this._originator.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
                return;

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                this._originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
