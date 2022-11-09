namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! This is the 3rd ovning");
            //Person person = new Person();
            //person.age = 6;

            //ARGUMENT EXCEPTION

            var ph = new PersonHandler();

            try
            {
                var person1 = new Person();
                //person1.Age = -1;
                ph.SetAge(person1, -1);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }

        }
    }
}