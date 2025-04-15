namespace CreationalDesignPattern_Singleton
{
    #region ## SINGLETON INTRODUCTION ##

    /// <summary>
    /// Singleton is a creational design pattern, which ensures that only one object of its kind exists 
    /// and provides a single point of access to it for any other code.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region ## FOR Naïve Singleton ##

            // The client code.
            NaïveSingleton s1 = NaïveSingleton.GetInstance();
            NaïveSingleton s2 = NaïveSingleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            #endregion

            #region ## FOR Thread-safe Singleton ##

            // The client code.

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() => { TestSingleton("FOO"); });
            Thread process2 = new Thread(() => { TestSingleton("BAR"); });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            #endregion
        }

        public static void TestSingleton(string value)
        {
            var singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
