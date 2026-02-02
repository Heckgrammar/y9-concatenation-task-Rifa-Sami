namespace Y9ConcatenationTaskAGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // add two more variables for the users last name and their age
            // take these inputs into the program
            // use the test data Bob, Smith, 14
            // ammend this code to output in one command
            // Hello Bob Smith you are 14 years old
            // save and commit your program
            // add evidence of the test input and your own input running the program 

            
            string FirstName;
            Console.Write("Enter first name: ");
            FirstName = Console.ReadLine();

            string LastName;
            Console.Write("Enter your last name: ");
            LastName = Console.ReadLine();

            string Age;
            Console.Write("Enter your age: ");
            Age = Console.ReadLine();

            Console.WriteLine("Hello " + FirstName + " " + LastName + " you are " + Age + " years old");
        }
    }
}
