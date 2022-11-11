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
            //Console.WriteLine($"program says {person.Age}");

            //Console.WriteLine($"Enter the age of the person?");
           
            //age = int.Parse(Console.ReadLine());
            person.Age = age;

        }

        public void SetFirstname(Person person, string fname)
        {
           // Console.WriteLine($"Enter the first name of the person?");

           // fname= Console.ReadLine();
            person.Fname = fname;
        }

        public void SetLastname(Person person, string lname)
        {
            //Console.WriteLine($"Enter the Last name of the person?");

           // lname = Console.ReadLine();
            person.Lname = lname;
        }

        public void SetHeight(Person person, double height)
        {
           // Console.WriteLine($"Enter the height of the person?");

            //height = double.Parse(Console.ReadLine());
            person.Height = height;
            //Console.WriteLine($"{person.Fname} {person.Lname} is {height}");
            //HOW TO HANDLE THIS EXEPTION?
           // CreatePerson(12, "emre", "sorkunm", 12.22, 12.33);
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)//add properties as input arguments
        {
            var newPerson = new Person(age, fname, lname, height, weight);
            return newPerson;
        }


    }
}
