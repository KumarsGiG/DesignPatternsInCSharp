namespace StructuralDesignPattern_Facade
{
    // Some facades can work with multiple subsystems at the same time.
    public class Subsystem2
    {
        public string Operation1()
            => "Subsystem2: Get ready!\n";

        public string OperationZ()
            => "Subsystem2: Fire!\n";
    }
}
