using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetFirstname(Person person, string fname)
        {

        }

        public Person CreatePerson()//add properties as input arguments
        {
            var newPerson = new Person();

            //give newPerson all properties

            return newPerson;
        }
    }
}
