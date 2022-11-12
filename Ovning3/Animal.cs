using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning3
{
    abstract class Animal
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
