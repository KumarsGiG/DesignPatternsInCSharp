﻿namespace BehavioralDesignPattern_Momento
{
    // The Concrete Memento contains the infrastructure for storing the originator's state.
    internal class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
            => this._state;

        // The rest of the methods are used by the Caretaker to display metadata.
        public string GetName()
            => $"{this._date} / ({this._state.Substring(0, 9)})...";

        public DateTime GetDate()
            => this._date;
    }
}
