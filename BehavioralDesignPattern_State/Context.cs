﻿namespace BehavioralDesignPattern_State
{
    // The Context defines the interface of interest to clients.
    // It also maintains a reference to an instance of a State subclass,
    // which represents the current state of the Context.
    public class Context
    {
        // A reference to the current state of the Context.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        private State _state = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        public Context(State state)
            => this.TransitionTo(state);

        // The Context allows changing the State object at runtime.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Request1()
            => this._state.Handle1();

        public void Request2()
            => this._state.Handle2();
    }
}
