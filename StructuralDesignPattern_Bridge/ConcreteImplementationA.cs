namespace StructuralDesignPattern_Bridge
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
            => "ConcreteImplementationA: The result in platform A.\n";
    }
}
