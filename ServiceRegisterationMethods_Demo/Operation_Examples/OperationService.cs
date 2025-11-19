namespace ServiceRegisterationMethods_Demo.Operation_Examples
{
    public class OperationService
    {
        public readonly ITeransientOperation _teransient;

        public OperationService(ITeransientOperation teransient)
        {
            _teransient = teransient;

            Console.Write("operationSevice result: ");
            Console.WriteLine($"TransientOperation: {_teransient.OperationId}");
        }
    }
}
