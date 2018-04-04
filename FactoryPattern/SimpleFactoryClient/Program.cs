using System;
using SimpleFactoryPattern;

namespace SimpleFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore myStore = new PizzaStore(factory);

            var cheesePizza = myStore.OrderPizza("cheese");            
            Console.WriteLine(cheesePizza.Information());

            var pepperoniPizza = myStore.OrderPizza("pepperoni");
            Console.WriteLine(pepperoniPizza.Information());

            var meatLoverPizza = myStore.OrderPizza("meatlover");
            Console.WriteLine(meatLoverPizza.Information());

            Console.ReadKey();
        }
    }
}
