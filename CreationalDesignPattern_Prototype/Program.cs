﻿namespace CreationalDesignPattern_Prototype
{
    #region ## PROTOTYPE INTRODUCTION ##

    /// <summary>
    /// Prototype is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Perform a shallow copy of p1 and assign it to p2.
            var p2 = p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            var p3 = p1.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            Console.ReadLine();
        }

        public static void DisplayValues(Person person)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                person.Name, person.Age, person.BirthDate);
            Console.WriteLine("      ID#: {0:d}", person.IdInfo.IdNumber);
        }
    }
}
