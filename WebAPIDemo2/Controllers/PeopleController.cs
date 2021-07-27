using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo2.Models;

namespace WebAPIDemo2.Controllers
{
    /// <summary>
    /// This is a random comment for DEMO XML Comment
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();  //OBJECT
        public PeopleController()  //CONSTRUCTOR
        {
            people.Add(new Person { FirstName = "Angel", LastName = "Davis", Id = 1 });
            people.Add(new Person { FirstName = "Elisha", LastName = "Davis", Id = 2 });
            people.Add(new Person { FirstName = "Isaiah", LastName = "Davis", Id = 3 });
        }

        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]  //Override Default route-This is the specific route for THIS Method
        [HttpGet] //Tells it what HTTP Types to accept / try route in postman w GET
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault(); //Passing an ID
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
