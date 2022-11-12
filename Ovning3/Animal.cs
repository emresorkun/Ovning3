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
        //KONSTRUKTOR
        public Animal(String name, Double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public class Horse : Animal
        {
            public Horse(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Horse goes horsesound");
            }
        }
        public class Dog : Animal
        {
            public Dog(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Horse goes dogsound");
            }
        }
        public class Hedgehog : Animal
        {
            public Hedgehog(string name, double weight, int age) : base(name, weight, age)
            {
                
            }

            public override void DoSound()
            {
                Console.WriteLine("Horse goes hedgesound");
            }
        }

        //WORM BIRD AND WOLF WILL BE ADDED 

    }
}
