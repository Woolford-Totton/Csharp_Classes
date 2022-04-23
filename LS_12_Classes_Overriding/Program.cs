#region ""



using System;

namespace LS_12_Classes_Overriding
{
    class Program
    {
        #endregion
        /*
            Lesson 12 Classes Overiding-

            Welcome to lesson 12 Classes Overiding.

            Now that your accustomed to creating classes and inheriting from them its time to learn 
            about overiding functions and polymorphism.
            
             class MyClass
            {               

                public virtual void myFunc()
                {
                    Console.WriteLine("MyFunc call Function");
                }               
            }
            class MyInheritedClass : MyClass
            {              
                public override void myFunc() // this function is called instead of MyClass myFunc
                {              
                    Console.WriteLine("Overided MyClass myFunc Function");
                }

            }
            
            Within our parent class we use the virtual keyword to declare myFunc is able 
            to be overidden by any child classes.

            
            Within our child class MyInheritedClass we use the override keyword to take 
            over the function myfunc from the parent class MyClass

            
            
            
            
         */

        static void Main(string[] args)
        {

            MyClass YourClass = new MyClass();



            YourClass.myFunc();

            MyInheritedClass YourInheritedClass = new MyInheritedClass();
           


            YourInheritedClass.myFunc();

            
        }
        class MyClass
        {
            public virtual void myFunc()
            {
                Console.WriteLine("MyFunc call Function");
            }          
        }
        class MyInheritedClass : MyClass
        {    
            public override void myFunc() // this function is called instead of MyClass myFunc
            {               
                Console.WriteLine("Overided MyClass myFunc Function");
            }

        }
       

        #region ""
    }
}
#endregion