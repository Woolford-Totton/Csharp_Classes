#region ""



using System;

namespace LS_11_Classes_Inheritance
{
    class Program
    {
        #endregion
        /*
            Lesson 11 Classes Inheritance-

            Welcome to lesson 11 Classes Inheritance.

            Inheritance is a way for you to avoid having to recreate the same function for different classes

            When a class inherits from another class (known as parent class) that child class gains all
            variables and functions.

            To do inheritance in your program you do:

            class ParentClass
            {
                public int myint-0;

                
            }
            
            class InheritedClass: ParentClass
            {
            
            }
            
            The public member myint can be accessed within the InheritedClass
            
            
            Members in a class dont have to be just public- there are 3 variations you can declare a member 
            in a class:

            Public- Can be accessed by any inherited class or variable 

            Private- Can only be accessed within the class declaration

            Protected- Can only be accessed within the class declaration and inherited class.

            You can also have your classes perform a function on creation (known as initialisation)
        
            This is achieved as so:

            class MyClass
            {
                public float myfloat;
                
                public MyClass()
                {
                    myfloat=0.0f;
                    Console.WriteLine("You created me :)");
                }
            }
            
            Now when you create a variable with the datatype MyClass 
        
            MyClass main_class_variable= new MyClass();

            You will be performing the initialisation funciton automatically.
        
            You can also have a function perform when you delete a class in your program and thats using 
            what is known as a deconstructor.
            
            class MyClass
            {
                public float myfloat;
                
                public ~MyClass()
                {
                    myfloat=0.0f;
                    Console.WriteLine("I am being destroyed :(");
                }
            }
            
            A deconstructor is called when your program is no longer referencing it in code.
            
            
         */

        static void Main(string[] args)
        {
           
            MyInheritedClass YourInheritedClass = new MyInheritedClass();            

            YourInheritedClass.my_float = 7;

            Console.WriteLine(YourInheritedClass.my_float);

            YourInheritedClass.myFunc();

            YourInheritedClass.myotherFunc();
        }     
        class MyClass
        {
            protected int my_int;

            public void myFunc()
            {
                Console.WriteLine("Call Function");
               
            }           
            public MyClass()
            {
                my_int = 3;
                Console.WriteLine("You created me :)");
            }
            ~MyClass()
            {
                my_int = 4;
                Console.WriteLine("I am being destroyed :(");
            }
        }
        class MyInheritedClass : MyClass
        {
            public float my_float;
            public void myotherFunc()
            {
                Console.WriteLine("My parents myint value is:"+ my_int);
                
            }           
           
        }


        #region ""
    }
}
#endregion