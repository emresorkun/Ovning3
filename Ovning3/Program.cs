namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {

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