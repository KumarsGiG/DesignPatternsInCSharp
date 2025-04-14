namespace StructuralDesignPattern_Composite
{
    #region ##  ##

    /// <summary>
    /// Composite is a structural design pattern that lets you compose 
    /// objects into tree structures and then work with these structures 
    /// as if they were individual objects.
    /// </summary>

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            // This way the client code can support the simple leaf components...
            var leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            var tree = new Composite();
            var branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            var branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);

            Console.ReadLine();
        }
    }
}
