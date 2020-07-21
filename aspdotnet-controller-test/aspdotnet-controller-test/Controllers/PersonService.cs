using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnet_controller_test.Controllers
{
    public class PersonService : IPersonService
    {

        private static List<Person> _allPeople = new List<Person>
        {
            new Person {
                Id = 1,
                Name= "aija"
            },
            new Person {
                Id = 2,
                Name= "janis"
            },
            new Person {
                Id = 3,
                Name= "andris"
            }
        };
        public Person AddPerson(Person person)
        {
            _allPeople.Add(person);
            return person;
        }

        public Person DeletePersonById(int id)
        {
            var personToDelete = _allPeople.FirstOrDefault(x => x.Id == id);
            _allPeople.Remove(personToDelete);
            return personToDelete;
        }

        public List<Person> GetAllPeople()
        {
            return _allPeople;
        }

        public Person GetPersonById(int id)
        {
            return _allPeople.FirstOrDefault(x => x.Id == id);
        }

        public Person UpdatePerson(Person person)
        {
            var personToUpdate = _allPeople.FirstOrDefault(x => x.Id == person.Id);
            personToUpdate.Name = person.Name;
            return personToUpdate;
        }
    }
}
