 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class Person
    {
        private int age;
        public int Age
        {
            get => age;
            set {
                if (age>0)
                {
                    age=value;
                }
            }
        }


        private string fname;  
        private string lname;
        private int height;
        private int weight;

        public string SetName()
        {
            //fname is obligatory and at least 2 and no more then 10
            return fname;  
        }

        //public string SetAge()
        //{
        //    //age should be more then 0
        //    return age;
        //}

        //public string lname()
        //{
        //    //lname is obligatory and at least 3 and no more then 15
        //    return lname;
        //}

        
    }
}
