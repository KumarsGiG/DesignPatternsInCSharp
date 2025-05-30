﻿namespace CreationalDesignPattern_AbstractFactory
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA() => "The result of the product A1.";
    }
}
