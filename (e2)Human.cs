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
            Console.WriteLine("Hi! I'm {0} {1}. I have {2} eyes and my age is {3}.", firstName, lastName, eyeColor, age);
        }


    }
}
