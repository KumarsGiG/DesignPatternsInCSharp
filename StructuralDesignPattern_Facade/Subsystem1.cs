namespace StructuralDesignPattern_Facade
{
    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class Subsystem1
    {
        public string Operation1()
            => "Subsystem1: Ready!\n";

        public string OperationN()
            => "Subsystem1: Go!\n";
    }
}
