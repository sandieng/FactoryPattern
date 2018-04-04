namespace SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string type)
        {          
            switch (type)
            {
                case "cheese":
                    return new CheesePizza();
                case "pepperoni":
                    return new PepperoniPizza();
                case "meatlover":
                    return new MeatLoverPizza();
            }

            return null;
        }
    }
}
