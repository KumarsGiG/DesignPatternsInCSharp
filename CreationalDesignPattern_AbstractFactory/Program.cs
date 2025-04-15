namespace CreationalDesignPattern_AbstractFactory
{
    #region ## ABSTRACT FACTORY INTRODUCTION ##

    /// <summary>
    /// Abstract Factory is a creational design pattern, which solves the problem of creating 
    /// entire product families without specifying their concrete classes.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            new Client().MainMethod();

            Console.ReadLine();
        }
    }
}
