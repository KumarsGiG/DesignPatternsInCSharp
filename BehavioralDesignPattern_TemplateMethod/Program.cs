namespace BehavioralDesignPattern_TemplateMethod
{
    #region ## TEMPLATE METHOD INTRODUCTION ##

    /// <summary>
    /// Template Method is a behavioral design pattern that allows you to define a skeleton
    /// of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm’s structure.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            Console.ReadLine();
        }
    }
}
