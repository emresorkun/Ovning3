 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class Person
    {
        private int age;
        public int Age
        {
            get => age;
            set {
                if (value > 0)
                {
                    age=value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be smaller than 0");
                }
            }
        }


        private string fname = string.Empty;
        public string Fname
        {
            get => fname;
            set{
                if (value.Length>2 && value.Length<10)
                {
                    fname = value;
                }
                else
                {
                    throw new ArgumentException("First Name can not be shorter than 2 letters or should be shorter than 10");
                }
            }
        }

        private string lname = String.Empty;
        public string Lname
        {
            get => lname;
            set
            {
                if (value.Length > 3 && value.Length < 15)
                {
                    lname = value;
                }
            }
        }

        private double height;
        public double Height
        {
            get => height;
            set
            {
                height = value;
            }
        }
        private double weight;
        public double Weight { get; set; }

        public Person(int age, string fname, string lname, double height, double weight)
        {
           Age = age;
           Fname = fname;
           Lname = lname;
           Height = height;
           Weight = weight;
        }  
           


        
    }
}
