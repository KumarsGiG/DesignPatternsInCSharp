﻿namespace BehavioralDesignPattern_ChainOfResponsibility
{
    internal class DogHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            if (request.ToString() == "MeatBall")
                return $"Dog: I'll eat the {request.ToString()}.\n";

            return base.Handle(request);
        }
    }
}
