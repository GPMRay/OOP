using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human()
        {
            Console.WriteLine("Constructor called.");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName; // We use 'this.firstName' to use the value of the global variable and equal that to the local variable.
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member
        public void IntroduceMySelf()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi! I'm {0} {1} and {2} year old. My eye color is {3}", firstName, lastName, age, eyeColor);
            }
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi! I'm {0} {1} and {2} years old", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi! I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi! I'm {0}", firstName);
            }
        }


    }
}
