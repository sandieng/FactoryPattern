using System;
using FactoryMethodPattern;
using FactoryMethodPattern.ChicagoStyle;

namespace FactoryMethodClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NyPizzaStore();
            var cheesePizza = nyStore.OrderPizza("cheese");            
            Console.WriteLine($"Pizza name: {cheesePizza.Name}, dough: {cheesePizza.Dough}, sauce: {cheesePizza.Sauce}");

            PizzaStore chicagoStore = new ChicagoPizzaStore();
            var clamPizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine($"Pizza name: {clamPizza.Name}, dough: {clamPizza.Dough}, sauce: {clamPizza.Sauce}");

            Console.ReadKey();
        }
    }
}
