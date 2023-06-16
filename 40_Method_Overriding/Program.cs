// Method overriding:
// Provides a new version of a method inherited from a parent class.
// Inherited method must be: abstract, virtual or already overridden
// Used with ToString(), polymorphism.

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadLine();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes 'brrr'.");
        }
    }
    class  Dog : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes 'woof woof'.");
        }
    }
    class Cat : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes 'meow meow'.");
        }
    }
}
