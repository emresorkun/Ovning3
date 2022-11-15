using System.Collections.Generic;


namespace Ovning3

{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Animal.Dog emre = new Animal.Dog("e", 1, 1);
            emre.Name = "eee";
            emre.DoSound();
            Console.WriteLine(emre.Name);
            Animal.Wolf kurt = new Animal.Wolf("1", 1, 1);
            Console.WriteLine(kurt.Age);
            // CANT REACH WOLF?? 
            //Wolf emre = new Wolf("ad", 12, 12);

            //ASK HOW TO THE THE LIST!!

            //List<UserError> list1 = new List<UserError>();
            //list1.Add();
            //list1.Add();
            //list1.Add();

            //UserError userError = new UserError();

            //ARGUMENT EXCEPTION
            //Ask user for inputs - Not nessasary

            var ph = new PersonHandler();
            //Person person1 = ph.CreatePerson(23, "Kalle", "Anka", 23, 70);

            Person person2 = ph.CreatePerson(43, "emre", "sorkun", 43,80);

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

           

        }


    }

}