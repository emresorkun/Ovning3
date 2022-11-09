namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            
            
            //ARGUMENT EXCEPTION
            //Ask user for inputs - Not nessasary

            var ph = new PersonHandler();
            Person person1 = ph.CreatePerson(23, "Kalle", "Anka", 23, 70);

            try
            {
               // var person1 = new Person();
                //person1.Age = -3;
                ph.SetAge(person1, 1);
                ph.SetFirstname(person1, "default");
                ph.SetLastname(person1, "default");
                ph.SetHeight(person1, 12.12);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }

        }
    }
}