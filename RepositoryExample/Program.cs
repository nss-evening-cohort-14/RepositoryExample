using System;

namespace RepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new PeopleRepository();

            repo.Add(new Person { Name = "Nathan" });

            var repo2 = new PeopleRepository();
            
            var allThePeople = repo2.GetAll();
        }
    }
}
