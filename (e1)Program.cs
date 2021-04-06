using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of Human
            Human edward = new Human();
            // access public variable from outside, and even change it.
            edward.firstName = "Edward";
            edward.lastName = "Davidson";
            // call methods of the class
            edward.IntroduceMySelf();

            Human jake = new Human(); // Create's a new object of the Human class
            jake.firstName = "Ricky"; // Assigns the public variable
            jake.lastName = "Johnson";
            jake.IntroduceMySelf(); // Calls the method

            Console.ReadKey();
        }

    }
}
