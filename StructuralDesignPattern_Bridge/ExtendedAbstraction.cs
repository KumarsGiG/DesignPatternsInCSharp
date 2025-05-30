﻿namespace StructuralDesignPattern_Bridge
{
    // You can extend the Abstraction without changing the Implementation classes.
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation) { }

        public override string Operation()
            => "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
    }
}
