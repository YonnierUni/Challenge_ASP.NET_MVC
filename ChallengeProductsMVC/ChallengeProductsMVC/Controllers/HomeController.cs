using Microsoft.AspNetCore.Mvc;
using PTCData;
using System.Diagnostics;

namespace ChallengeProductsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TrainingProductViewModel vm = new TrainingProductViewModel();

            vm.HandleRequest();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(TrainingProductViewModel vm)
        {
            vm.IsValid = ModelState.IsValid;
            vm.HandleRequest();

            if (vm.IsValid)
            {
                ModelState.Clear();
            }

            return View(vm);
        }

    }
}