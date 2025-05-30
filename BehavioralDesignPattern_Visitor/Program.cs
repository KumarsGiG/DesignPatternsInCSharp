﻿namespace BehavioralDesignPattern_Visitor
{
    #region ## VISITOR INDTRODUCTION ##

    /// <summary>
    /// Visitor is a behavioral design pattern that allows adding new behaviors 
    /// to existing class hierarchy without altering any existing code.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}
