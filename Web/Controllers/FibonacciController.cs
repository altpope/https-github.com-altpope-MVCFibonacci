using System.Web.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class FibonacciController : Controller
    {
        private readonly IFibonacciService _service;

        public FibonacciController(IFibonacciService service)
        {
            _service = service;
        }

        public FibonacciController()
        {
            //_service = new FibonacciService();
            _service = DependencyResolver.Current.GetService<IFibonacciService>();
        }
        [HttpGet]
        public ActionResult Index(int number = 10)
        {
            var viewModel = new FibonacciViewModel
            {
                Results = _service.GenerateFibonacciSequence(number),
                NumberRequested = number
            };

            return View(viewModel);
        }
        //[HttpGet]
        //public ViewResult Index()
        //{
        //    var viewmodel = new FibonacciViewModel();

        //    return View(viewmodel);
        //}
        [HttpPost]
        public ActionResult Index(string number)
        {
            int inputnumber = int.TryParse(number, out inputnumber) ? inputnumber : (-1);

            var viewModel = new FibonacciViewModel
            {
                Results = _service.GenerateFibonacciSequence(inputnumber),
                NumberRequested = inputnumber
            };

            return View(viewModel);


        }
    }
}