﻿namespace StructuralDesignPattern_Decorator
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp) { }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
            => $"ConcreteDecoratorA({base.Operation()})";
    }
}
