using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    // this class is a blueprint for a datatype
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        // member
        public void IntroduceMySelf()
        {
            Console.WriteLine("Hi! I'm {0} {1}", firstName, lastName);
        }


    }
}
