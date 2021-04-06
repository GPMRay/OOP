using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Human denis = new Human("Denis", "Panjuta", "green", 29);
            denis.IntroduceMySelf(); // Grabs the information specified in 'denis' and calls the method in Human.cs

            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMySelf();

            Human basiHuman = new Human();
            basiHuman.IntroduceMySelf();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMySelf();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMySelf();

            Human frank = new Human("Frank", "Walter", 29);
            frank.IntroduceMySelf();

            Console.ReadKey();
        }

    }
}
