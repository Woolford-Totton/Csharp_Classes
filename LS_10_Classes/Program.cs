#region ""



using System;

namespace LS_10_Classes
{
    class Program
    {
        #endregion
        /*
            Lesson 10 Classes-

            Welcome to lesson 10 Classes.

            Classes are the next level up from functions.

            A class is a datatype that you define and give it its own functions and variables.

            The basic syntax to define a class is:

             class YourClass
            {
               
            }

            To create a variable that uses your newly defined datatype you do:

            YourClass Classvariable= new YourClass();

            To give your class a member variable you do:

             class YourClass
            {
               public int Class_int;
            }
            
            A member within a class can be either public, private or protected 
            (Dont worry about protected for now)

            A public member is something that can be accessed by any variable using its class.

            A private member can only be accessed by the class itself rather than any variable 
            using its datatype.
            
            To give a class a function all you need to do is state whther that function is public or private 
            inside the function:

             class YourClass
            {
               public int Class_int;

                public void myFunction()
                {
                    //Do code here
                }
            }

            To access a member within the class (assuming its public) you do:

            YourClass Classvariable= new YourClass();

            Classvariable.myFunction();
            Classvariable.Class_int;

            
            
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass YourClass= new MyClass();

            YourClass.my_int = 7;

            Console.WriteLine(YourClass.my_int);

            YourClass.myFunc();

            
        }
        class MyClass
        {
            public int my_int;

            public void myFunc()
            {
                Console.WriteLine("Call Function");
            }
        }
#region ""
    }
}
#endregion