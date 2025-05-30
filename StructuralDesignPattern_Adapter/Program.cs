﻿namespace StructuralDesignPattern_Adapter
{
    #region ## ADAPTER INTRODUCTION ##

    /// <summary>
    /// Adapter is a structural design pattern, which allows incompatible objects to collaborate.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.ReadLine();
        }
    }
}
