using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceRegisterationMethods_Demo.Operation_Examples;

namespace ServiceRegisterationMethods_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly OperationService _operationService;
        private readonly ITeransientOperation _transient;


        public IndexModel(ITeransientOperation transient, OperationService operationService)
        {
            _transient = transient;
            _operationService = operationService;

            Console.WriteLine("index Model result  : ");
            Console.WriteLine($"TransientOperation: {_transient.OperationId}");
            Console.WriteLine("____________________________________________________");
        }

        public void OnGet()
        {

        }
    }
}
