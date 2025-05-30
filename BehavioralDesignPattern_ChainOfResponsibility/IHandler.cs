﻿namespace BehavioralDesignPattern_ChainOfResponsibility
{
    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object? Handle(object request);
    }
}
