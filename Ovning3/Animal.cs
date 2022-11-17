using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public bool IsSpicky { get; set; }
        public Hedgehog(string name, double weight, int age, bool isSpicky) : base(name, weight, age)
        {
            IsSpicky= isSpicky;
        }

        public override string DoSound()
        {
            return "Hedgehog does hedgesound";
        }
        public override string Stats()
        {
            return base.Stats() + $" Is s/he spicky: {IsSpicky} ";
        }
    }

    public class Wolf : Animal
    {
        public int PackPopulation { get; set; }
        public Wolf(string name, double weight, int age, int packPopulation) : base(name, weight, age)
        {
            PackPopulation = packPopulation;
        }

        public override string DoSound()
        {
            return "Wolf does wolfffff wolfff";
        }
        public override string Stats()
        {
            return base.Stats() + $" A member  of a pack of: {PackPopulation} ";
        }
    }

    public class Bird : Animal
    {

        public double WingLength { get; set; }
        public Bird(string name, double weight, int age, double wingLength) : base(name, weight, age)
        {
            WingLength = wingLength;
        }

        public override string DoSound()
        {
            return "bird says cick";
        }
        public override string Stats()
        {
            return base.Stats() + $" has a wing length of. {WingLength} ";
        }
    }

    public class WolfMan: Animal

    {
        public bool Ishesafe { get; set; }
        public WolfMan(string name, double weight, int age, bool isheSafe) : base(name, weight, age)
        {
            Ishesafe = isheSafe;
        }

        public bool Fullmoon { get; set; } = true;
        
        public override string DoSound()
        {
            return "WOLFI WOLFUUUUU";
        }

        public override string Stats()
        {
            if (Fullmoon)
            {
                Ishesafe = false;

                return $"oh my god {base.Stats()} RUN!";
            }
            else
            {
                Ishesafe = true;
                return $"HE IS A GOOD BOY {base.Stats()} UNRUN!";
            }

            
        }

    }

    public class Pelican : Bird
    {
        private object allergies;

        public List<string> Allergies { get; set; }
        public Pelican(string name, double weight, int age, double wingLength, List<string> allergies) : base(name, weight, age, wingLength)
        {
            Allergies = allergies;
        }
        public override string Stats()
        {
            var sb = new StringBuilder();

            foreach(var allergy in Allergies)
            {
                sb.Append($"{allergy},");
            }

            return $"{base.Stats()}, Allergies: {sb.ToString()}";
            //byga a string of a list and look and create a 
        }
    }

    //WORM BIRD AND WOLF WILL BE ADDED 
}

