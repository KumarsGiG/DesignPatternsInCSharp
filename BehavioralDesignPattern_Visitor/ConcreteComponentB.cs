﻿namespace BehavioralDesignPattern_Visitor
{
    public class ConcreteComponentB : IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor) => visitor.VisitConcreteComponentB(this);

        public string SpecialMethodOfConcreteComponentB() => "B";
    }
}
