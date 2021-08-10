using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    class PeopleRepository
    {
        // we're using a static list here instead of a proper database
        // but the general idea still holds up once we cover databases
        // it's just another piece of code to replace and refactor nbd
        static List<Person> _people = new List<Person>
        {
            new Person{Name="Bob"},
            new Person{Name="Steve"},
            new Person{Name="Jim"},
            new Person{Name="Larry"},
            new Person{Name="Curly"},
        };

        public List<Person> GetAll()
        {
            return _people;
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Delete(string name)
        {
            var personToRemove = _people.First(person => person.Name == name);

            _people.Remove(personToRemove);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
