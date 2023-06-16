// Overloaded constructors: 
// Technique to create multiple constructors, with different set of parameters.
// name + parameters = signature 

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("thin crust", "tomato sauce", "mozzarella", "basil");
            Pizza pizza2 = new Pizza("stuffed crust", "tomato sauce", "parmesan");
            Pizza pizza3 = new Pizza("normal", "white sauce", "mozzarella", "tuna", "red onion", "capers");
                        
            Console.ReadKey();
        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping1;
        String topping2;
        String topping3;
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping1)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping1 = topping1;
        }
        public Pizza(String bread, String sauce, String cheese, String topping1, String topping2)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping1 = topping1;
            this.topping2 = topping2;
        }
        public Pizza(String bread, String sauce, String cheese, String topping1, String topping2, String topping3)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping1 = topping1;
            this.topping2 = topping2;
            this.topping3 = topping3;  
        }
    }
}
