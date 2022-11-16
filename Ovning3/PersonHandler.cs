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
           person.Fname = fname;
        }

        public void SetLastname(Person person, string lname)
        {
            person.Lname = lname;
        }

        public void SetHeight(Person person, double height)
        {
            person.Height = height;

        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)//add properties as input arguments
        {
            var newPerson = new Person(age, fname, lname, height, weight);
            return newPerson;
        }

    }
}
