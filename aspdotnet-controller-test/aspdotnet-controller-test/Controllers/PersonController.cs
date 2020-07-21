using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspdotnet_controller_test.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class PersonController : ControllerBase
    {


        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return _personService.GetAllPeople();
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            //var person = _allPeople.FirstOrDefault(x => x.Id == id);
            var person = _personService.GetPersonById(id); 
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

        [HttpPost]
        public ActionResult<Person> Add(Person person)
        {
            _personService.AddPerson(person);
            return person;
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {

            //var personToDelete = _allPeople.FirstOrDefault(x => x.Id == id);
            var personToDelete = _personService.DeletePersonById(id);
            if (personToDelete == null)
            {
                return BadRequest();
            }
            //_allPeople.Remove(personToDelete);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Person> Update(Person person)
        {
            // var personToUpdate = _allPeople.FirstOrDefault(x => x.Id == person.Id);
            var personToUpdate = _personService.UpdatePerson(person);
            if (person == null)
            {
                return BadRequest();
            }
            //personToUpdate.Name = person.Name;
            return personToUpdate;
        }

    }
}
