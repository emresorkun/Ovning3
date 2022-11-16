using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
 
namespace Ovning3
{


    //stract class Animal
    public abstract class Animal
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

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"name: {name}, age:{age} weight: {Weight}";
        }

        

    }

    public class Horse : Animal
    {
        public string Breed { get; set; }   
        public Horse(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return "Horse does horsesound";
        }

        public override string Stats()
        {
            return base.Stats()+$" Breed: {Breed}";
        }
    }


    public class Dog : Animal
      {
        public bool IsGoodBoy { get; set; }
        public Dog(string name, double weight, int age, bool isGoodBoy) : base(name, weight, age)
        {
            IsGoodBoy = isGoodBoy;
        }

        public override string DoSound()
        {
            
            return "Dog does dogsound";
        }

        public override string Stats()
        {
            return base.Stats()+$" Is a good boy: {IsGoodBoy} ";
        }
    }
    public class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age) : base(name, weight, age)
        {

        }

        public override string DoSound()
        {
            return "Hedgehog does hedgesound";
        }
    }

    public class Wolf : Animal
    {
        public Wolf(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "Wolf does wolfffff wolfff";
        }
    }



    //WORM BIRD AND WOLF WILL BE ADDED 
}

