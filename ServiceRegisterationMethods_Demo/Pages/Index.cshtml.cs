using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceRegisterationMethods_Demo.Operation_Examples;

namespace ServiceRegisterationMethods_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISingletonOperation _singleton;
        private readonly OperationService _operationService;
        private readonly ITeransientOperation _transient;
        private readonly IScopedOperation _scoped;


        public IndexModel(ITeransientOperation transient, OperationService operationService, IScopedOperation scoped, ISingletonOperation singleton)
        {
            _transient = transient;
            _operationService = operationService;
            _scoped = scoped;
            _singleton = singleton;

            Console.WriteLine("index Model result  : ");
            Console.WriteLine($"TransientOperation: {_transient.OperationId}");
            Console.WriteLine($"ScopedOperation: {_scoped.OperationId}");
            Console.WriteLine($"SingletonOperation: {_singleton.OperationId}");

            Console.WriteLine("____________________________________________________");
        }

        public void OnGet()
        {

        }
    }
}
