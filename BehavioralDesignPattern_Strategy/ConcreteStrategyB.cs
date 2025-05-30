﻿namespace BehavioralDesignPattern_Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
