using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnet_controller_test.Controllers
{
    public class PersonUiController : Controller
    {
        private IPersonService _personService;
        public PersonUiController(IPersonService personService)
        {
            _personService = personService;
        }
 
        public IActionResult Index()
        {
            var persons = _personService.GetAllPeople();
            return View(persons);
        }
        public IActionResult GetPerson(int id)
        {
            var person = _personService.GetPersonById(id);
            return View(person);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Person person)
        {
            _personService.AddPerson(person);
            return RedirectToAction("Index");
        }

    }
}
