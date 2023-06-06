namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void getUsersDetails()
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter lastName");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your Age");
                string age = Console.ReadLine();
                int integerAge = int.Parse(age);

                Console.WriteLine("name : " + name + " " + lastName +  " , age: " + integerAge);

            }

            getUsersDetails();
            getUsersDetails();

        }
    }
}