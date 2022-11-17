using System.Collections.Generic;
using System.Net.Http.Headers;
//using static Ovning3.Animal;

namespace Ovning3

{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            List<UserError> list1 = new List<UserError>();


            var ph = new PersonHandler();
            //Person person1 = ph.CreatePerson(23, "Kalle", "Anka", 23, 70);

            Person person2 = new PersonHandler().CreatePerson(43, "emre", "sorkun", 43,80);
            

            try
            {
               // var person1 = new Person();
                //person1.Age = -3;
                ph.SetAge(person2, 1);
                ph.SetFirstname(person2, "default");
                ph.SetLastname(person2, "default");
                ph.SetHeight(person2, 12.12);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                //throw; 
            }


            var animalFarm = new List<Animal>();
            animalFarm.Add(new Horse("frutti", 234,23,"tantuni"));

            var horse = new Horse("tuti", 250, 12, "taskesen");
            animalFarm.Add(horse);
            animalFarm[0].DoSound();
            animalFarm.Add(new Dog("karabas", 19, 12, false)) ;
            animalFarm.Add(new WolfMan("HANNIBAL", 12, 45, false));
            List<string> allergies = new List<string>();
            allergies.Add("eee");
            allergies.Add("bee");
            allergies.Add("cee");
            Console.WriteLine("Allergies "+allergies[2]);
            animalFarm.Add(new Pelican("TEST", 111, 1234, 12345, allergies));

            //animalFarm.Add(new Wolf("kurt", 12, 12));
            //HOW TO REACH KURT WHEN WE CREATED AND ADDED TO THE LIST? WE ARE NOT PLACING IT IN  A VAR?
            //var wolf1 = new Wolf("kurti", 12, 12);
            //animalFarm.Add(wolf1);
            //FOR EXAMPLE HERE WE HAVE A wolf1 variable...
            //Console.WriteLine(animalFarm[0]+" List 0");




            //Console.WriteLine(horse.DoSound());
            //Console.WriteLine($"{animalFarm[0].Name}  does häst sound ");
            //Console.WriteLine($"{animalFarm[1].Name}  does häst sound ");
            
            
            foreach (var animal in animalFarm)
            {
                Console.WriteLine(animal.Stats(), horse.Breed);

            

                Console.WriteLine(animal.DoSound()+"animal does the sound"); 
            }
        }


    }

}