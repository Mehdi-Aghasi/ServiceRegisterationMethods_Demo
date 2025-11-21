using System.IO.Pipes;

namespace ServiceRegisterationMethods_Demo.Operation_Examples
{
    public class OperationService
    {
        private readonly ITeransientOperation _teransient;
        private readonly IScopedOperation _scoped;
        private readonly ISingletonOperation _singleton;

        public OperationService(ITeransientOperation teransient, IScopedOperation scoped, ISingletonOperation singleton)
        {
            _teransient = teransient;
            _scoped = scoped;
            _singleton = singleton;

            Console.WriteLine("operationSevice result: ");
            Console.WriteLine($"TransientOperation: {_teransient.OperationId}");
            Console.WriteLine($"ScopedOperation: {_scoped.OperationId}");
            Console.WriteLine($"SingletonOperation: {_singleton.OperationId}");
        }
    }
}
