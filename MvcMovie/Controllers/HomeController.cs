using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            if(!ModelState.IsValid) {
                return BadRequest();
            }

            return Ok(viewModel);
        }

        public IActionResult Edit(Person model)
        {
            return Ok(model);
        }

        public IActionResult Privacy(int id, int colorIndex = 3)
        {
            ViewData["Index"] = colorIndex;
            return View();
        }

        public IActionResult Demo()
        {
            var model = new DemoViewModel();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new CountryViewModel();
            model.Country = "CA";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CountryViewModel model)
        {
            // if (ModelState.IsValid)
            // {
            //     var msg = model.Country + " selected";
            //     return RedirectToAction("Success", new { message = msg });
            // }

            // If we got this far, something failed; redisplay form.
            Console.WriteLine(System.DateTime.Now);
            return Ok(model);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Modify()
        {
            var model = new List<ToDoItem>{
                new ToDoItem { Name = "", IsDone = "" },
                new ToDoItem { Name = "", IsDone = "" },
                new ToDoItem { Name = "", IsDone = "" },
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Modify(ToDoItem model)
        {
            return Ok(model);
        }

        public IActionResult Enumpage()
        {
            var model = new CountryEnumViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult ResultPage(CountryEnumViewModel model)
        {
            return Ok(model);
        }

        public IActionResult CountryGroup()
        {
            var viewModel = new CountryViewModelGroup();
            return View(viewModel);
        }
        
        public IActionResult CountryIEnumeable()
        {
            var viewModel = new CountryViewModelIEnumerable();
            return View(viewModel);
        }

        public IActionResult IndexNone()
        {
            var model = new CountryViewModel();
            return View(model);
        }

        public IActionResult IndexTwice()
        {
            var model = new CountryViewModel();
            model.Countries.Insert(0, new SelectListItem("<none>", ""));
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
