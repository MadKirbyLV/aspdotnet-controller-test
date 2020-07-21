using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspdotnet_controller_test.Controllers
{
    public interface IPersonService
    {
        List<Person> GetAllPeople();
        Person GetPersonById(int id);
        Person AddPerson(Person person);
        Person DeletePersonById(int id);
        Person UpdatePerson(Person person);
    }
}
