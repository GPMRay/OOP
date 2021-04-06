using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Human ray = new Human("Ray", "John", "Brown", 42);
            ray.IntroduceMySelf(); // Grabs the information specified in 'ray' and calls the method in Human.cs

            Console.ReadKey();
        }

    }
}
