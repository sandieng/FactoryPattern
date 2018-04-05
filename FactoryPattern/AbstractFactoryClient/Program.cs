using AbstractFactoryPattern;
using System;

namespace AbstractFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            var cheesePizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Pizza name: {cheesePizza.Name}, dough: {cheesePizza.Dough}, sauce: {cheesePizza.Sauce}, cheese: {cheesePizza.Cheese}");
            var veggiePizza = nyStore.OrderPizza("veggie");
            Console.WriteLine($"Pizza name: {veggiePizza.Name}, dough: {veggiePizza.Dough}, sauce: {veggiePizza.Sauce}, cheese: {veggiePizza.Cheese}, veggies: {veggiePizza.Vegetables}");

            PizzaStore laStore = new LAPizzaStore();
            var laCheesePizza = laStore.OrderPizza("cheese");
            Console.WriteLine($"Pizza name: {laCheesePizza.Name}, dough: {laCheesePizza.Dough}, sauce: {laCheesePizza.Sauce}, cheese: {laCheesePizza.Cheese}");
            var laVeggiePizza = laStore.OrderPizza("veggie");
            Console.WriteLine($"Pizza name: {laVeggiePizza.Name}, dough: {laVeggiePizza.Dough}, sauce: {laVeggiePizza.Sauce}, cheese: {veggiePizza.Cheese}, veggies: {laVeggiePizza.Vegetables}");


            Console.ReadKey();
        }
    }
}
