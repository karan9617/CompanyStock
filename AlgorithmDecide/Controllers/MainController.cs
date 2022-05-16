using System;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmDecide.Controllers
{
    public class MainController: Controller
    {
        public MainController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
