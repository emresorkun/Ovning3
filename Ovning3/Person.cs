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
                    throw new ArgumentException("Age must be something else");
                }
            }
        }
        //        {
        //            get
        //            {if (age>0)
        //                {
        //                    age=value;
        //                }} 
        //            set {
        //                
        //}
        //        }


        private string fname;
        public string Fname
        {
            get => fname;
            set
            {
                if (value.Length>2 && value.Length<10)
                {
                    fname = value;
                }
            }
        }

        private string lname;
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


        private int height;
        private int weight;


        
    }
}
