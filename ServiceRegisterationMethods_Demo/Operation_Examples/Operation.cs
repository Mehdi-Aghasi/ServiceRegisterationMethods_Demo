namespace ServiceRegisterationMethods_Demo.Operation_Examples
{
    public class Operation: ITeransientOperation, IScopedOperation,ISingletonOperation
    {
        public Guid OperationId {  get; set; }

        public Operation()
        {
            OperationId = Guid.NewGuid();
        }
    }
}
